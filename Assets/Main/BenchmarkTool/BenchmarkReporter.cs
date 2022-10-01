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
                File.Move(logFileName, $"{logDir}/benchmark-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log");
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
            _baseLogger.WriteLine($"method,params,iteration,min(ms),max(ms),middle(ms)");
            foreach (var result in results)
            {
                long minCostTime = result.CostTimes.Min();
                long maxCostTime = result.CostTimes.Max();
                long averCostTime = (long)result.CostTimes.Average();
                string paramStr = result.Params != null ? string.Join("_", result.Params) : "";
                string logStr = $"{result.Method.DeclaringType.FullName}::{result.Method.Name},{paramStr},{result.CostTimes.Count},{minCostTime},{maxCostTime},{averCostTime}";
                _baseLogger.WriteLine(logStr);
                Debug.Log(logStr);
            }
            CloseLogFile();
        }
    }

}
