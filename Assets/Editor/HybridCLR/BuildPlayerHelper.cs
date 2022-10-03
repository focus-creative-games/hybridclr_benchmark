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

            string location = $"{outputPath}/HybridCLRBenchmark.exe";

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

            Debug.Log("====> 复制 dll");
            CopyDlls(target, $"{outputPath}/HybridCLRBenchmark_Data/StreamingAssets");

#if UNITY_EDITOR
            Application.OpenURL($"file:///{outputPath}");
#endif
        }
    }
}
