using BenchmarkTool;
using HybridCLR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Networking;

public class LoadDll : MonoBehaviour
{
    void Start()
    {
#if !UNITY_EDITOR
        StartCoroutine(DownLoadDlls(this.StartRunner));
#else
        StartRunner();
#endif
    }

    private static Dictionary<string, byte[]> s_dllBytes = new Dictionary<string, byte[]>();

    public static byte[] GetDllBytes(string dllName)
    {
        return s_dllBytes[dllName];
    }

    IEnumerator DownLoadDlls(Action onDownloadComplete)
    {
        var dlls = new string[]
        {
            "mscorlib",
            "System",
            "System.Core",
            "Main",
            "AOT",
            "Interpreter",
        };
        foreach (var dll in dlls)
        {
            string dllPath = $"{Application.streamingAssetsPath}/{dll}.dll";
            if (!dllPath.Contains("://"))
            {
                dllPath = "file://" + dllPath;
            }
            Debug.Log($"start download dll:{dllPath}");
            UnityWebRequest www = UnityWebRequest.Get(dllPath);
            yield return www.SendWebRequest();

#if UNITY_2020_1_OR_NEWER
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
#else
            if (www.isHttpError || www.isNetworkError)
            {
                Debug.Log(www.error);
            }
#endif
            else
            {
                // Or retrieve results as binary data
                byte[] dllBytes = www.downloadHandler.data;
                Debug.Log($"dll:{dll}  size:{dllBytes.Length}");
                s_dllBytes[dll] = dllBytes;
            }
        }

        onDownloadComplete();
    }


    public Assembly LoadAssembly(string assName)
    {
        var aotAss = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(ass => ass.GetName().Name == assName);
        if (aotAss != null)
        {
            return aotAss;
        }
        byte[] dllBytes = GetDllBytes(assName);
        return Assembly.Load(dllBytes);
    }


    private static unsafe void LoadAOTAssemblyMetadatas()
    {
        string[] aotDlls = new string[]
        {
            "mscorlib",
            "System",
            "System.Core",
            "Main",
            "AOT",
        };
        foreach (string dll in aotDlls)
        {
            byte[] dllBytes = GetDllBytes(dll);
            LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes);
            Debug.LogFormat("LoadMetadataForAOTAssembly:{0}. ret:{1}", dll, err);
        }
    }

    private void StartRunner()
    {
#if !UNITY_EDITOR
        LoadAOTAssemblyMetadatas();
#endif

        var runner = new BenchmarkRunner(new BenchmarkRunner.Options()
        {
            WarmUpIteration = 3,
            DefaultBenchmarkIteration = 10,
            BenchmarkAssemblyList = new List<Assembly> { LoadAssembly("AOT"), LoadAssembly("Interpreter") },
        });

        runner.Run();

        StartCoroutine(DelayAndQuit(0f));
    }

    private IEnumerator DelayAndQuit(float delay)
    {
        yield return new WaitForSeconds(delay);
#if !UNITY_EDITOR
        Application.Quit();
#endif
    }
}
