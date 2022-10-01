using HybridCLR.Editor.Commands;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace HybridCLR.Editor
{
    public class BuildPlayerHelper
    {
        public static void CopyDlls(BuildTarget target, string outputDir)
        {
            CopyDllHelper.CopyHotfixAndAOTDll2BuildStreamingAssetsDir(target, outputDir);
        }

        [MenuItem("HybridCLR/Build/Win64")]
        public static void Build_Win64()
        {
            BuildTarget target = BuildTarget.StandaloneWindows64;
            // Get filename.
            string outputPath = $"{SettingsUtil.ProjectDir}/Release-Win64";

            var buildOptions = BuildOptions.None;

            string location = $"{outputPath}/HybridCLRTest.exe";

            Debug.Log("====> Build App");
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions()
            {
                scenes = new string[] { "Assets/Scenes/main.unity" },
                locationPathName = location,
                options = buildOptions,
                target = BuildTarget.StandaloneWindows64,
                targetGroup = BuildTargetGroup.Standalone,
            };

            var report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            if (report.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded)
            {
                Debug.LogError("打包失败");
                return;
            }
            CompileDllCommand.CompileDll(target);

            Debug.Log("====> Build AssetBundle");
            Debug.Log("====> 复制 AssetBundle");
            CopyDlls(target, $"{outputPath}/HybridCLRTest_Data/StreamingAssets");

#if UNITY_EDITOR
            Application.OpenURL($"file:///{outputPath}");
#endif
        }

        //[MenuItem("HybridCLR/Build/Andriod64")]
        public static void Build_Android64()
        {
            BuildTarget target = BuildTarget.Android;
            // Get filename.
            string outputPath = $"{SettingsUtil.ProjectDir}/Release-Android";

            var buildOptions = BuildOptions.None;

            string location = outputPath + "/HybridCLRTest.apk";
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions()
            {
                scenes = new string[] { "Assets/Scenes/main.unity" },
                locationPathName = location,
                options = buildOptions,
                target = target,
                targetGroup = BuildTargetGroup.Android,
            };

            Debug.Log("====> 第1次 Build App(为了生成补充AOT元数据dll)");
            BuildPipeline.BuildPlayer(buildPlayerOptions);
            Debug.Log("====> Build AssetBundle");

            // FIX ME! need copy dlls 
            //CopyDlls($"{outputPath}/HybridCLRTest_Data/StreamingAssets");

            Debug.Log("====> 第2次打包");
            BuildPipeline.BuildPlayer(buildPlayerOptions);
#if UNITY_EDITOR
            Application.OpenURL($"file:///{outputPath}");
#endif
        }
    }
}
