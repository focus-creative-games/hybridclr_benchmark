using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BenchmarkTool
{
    public class BenchmarkReporter
    {
        private static FileStream _logFileStream;
        private static StreamWriter _baseLogger;

        private static string LogDir => Application.persistentDataPath + "/benchmarklogs";

        private static string LogFileName => $"{LogDir}/benchmark.csv";

        private void OpenLogFile()
        {
            string logDir = LogDir;
            Directory.CreateDirectory(logDir);

            var logFileName = LogFileName;
            if (File.Exists(logFileName))
            {
                File.Move(logFileName, $"{logDir}/benchmark-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.csv");
            }
            _logFileStream = File.OpenWrite(logFileName);
            _baseLogger = new StreamWriter(_logFileStream);
        }

        private void CloseLogFile()
        {
            _baseLogger.Flush();
            _baseLogger.Close();
#if UNITY_STANDALONE_WIN && !UNITY_EDITOR
        Application.OpenURL($"file:///{LogFileName}");
#endif
        }

        public void GenerateReport(List<BenchmarkResult> results)
        {
            OpenLogFile();
            _baseLogger.WriteLine($"assembly,method,params,min(ms),max(ms),average(ms), middle(ms)");
            foreach (var result in results)
            {
                string assemblyName = result.Method.Module.Name;
                assemblyName = assemblyName.Substring(0, assemblyName.IndexOf(".dll"));
                long minCostTime = result.CostTimes.Min();
                long maxCostTime = result.CostTimes.Max();
                result.CostTimes.Sort((a, b) => a.CompareTo(b));
                long midCostTime = result.CostTimes[result.CostTimes.Count / 2];
                long averageCostTime = (long)result.CostTimes.Average();
                string paramStr = result.Params != null ? string.Join("_", result.Params) : "";
                string logStr = $"{assemblyName},{result.Method.DeclaringType.FullName}::{result.Method.Name},{paramStr},{minCostTime},{maxCostTime},{averageCostTime},{midCostTime}";
                _baseLogger.WriteLine(logStr);
                Debug.Log(logStr);
            }
            CloseLogFile();
        }
    }

}
