using HybridCLR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace BenchmarkTool
{

    public class BenchmarkRunner
    {
        public class Options
        {
            public int WarmUpIteration { get; set; }

            public int DefaultBenchmarkIteration { get; set; }

            public List<Assembly> BenchmarkAssemblyList { get; set; }
        }


        private int WarmUpIteration { get; }

        private int DefaultBenchmarkIteration { get; }

        private List<Assembly> BenchmarkAssemblyList { get; }

        private readonly List<BenchmarkCase> _benchmarkCases = new List<BenchmarkCase>();

        private readonly List<BenchmarkResult> _benchmarkResults = new List<BenchmarkResult>();

        public BenchmarkRunner(Options options)
        {
            this.WarmUpIteration = options.WarmUpIteration;
            this.DefaultBenchmarkIteration = options.DefaultBenchmarkIteration;
            this.BenchmarkAssemblyList = options.BenchmarkAssemblyList;
        }

        public void Run()
        {
            PrepareBenchmarkCases();

            WarmUp();

            RunAllBenchmarkCases();

            var reporter = new BenchmarkReporter();
            reporter.GenerateReport(_benchmarkResults);
        }


        private void CollectBenchmarkCases(Type type)
        {
            foreach (var method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                var benchmarkAttr = method.GetCustomAttribute<BenchmarkAttribute>();
                if (benchmarkAttr == null)
                {
                    continue;
                }
                int paramCount = method.GetParameters().Length;
                var paramsList = new List<object[]>();
                foreach(ParamsAttribute paramsAttr in method.GetCustomAttributes<ParamsAttribute>())
                {
                    if (paramsAttr.Values.Length != paramCount)
                    {
                        throw new ArgumentException($"ParamsAttribute.Values.Length:{paramsAttr.Values.Length} != method.ParamCount:{paramCount}. method:{method}");
                    }
                    paramsList.Add(paramsAttr.Values);
                }
                if (paramCount != 0 && paramsList.Count == 0)
                {
                    throw new ArgumentException($"method:{method} paramCount > 0. You should provide at lease one ParamsAttribute.");
                }
                var bc = new BenchmarkCase()
                {
                    Method = method,
                    RunIteration = benchmarkAttr.RunIteration,
                    ParamsList = paramsList,
                };
                _benchmarkCases.Add(bc);
            }
        }

        private void PrepareBenchmarkCases()
        {
            foreach (var ass in BenchmarkAssemblyList)
            {
                foreach(var type in ass.GetTypes())
                {
                    CollectBenchmarkCases(type);
                }
            }
            //Debug.Log($"total benchmark case count:{_benchmarkCases.Count}");
        }

        private void WarmUp()
        {
            for(int i = 0; i < WarmUpIteration; i++)
            {
                //Debug.Log($"WarmUp round[{i + 1}] begin");
                foreach (var bc in _benchmarkCases)
                {
                    if (bc.Method.GetParameters().Length != 0)
                    {
                        foreach (var args in bc.ParamsList)
                        {
                            RunCase(bc.Method, args);
                        }
                    }
                    else
                    {
                        RunCase(bc.Method, null);
                    }
                }
                //Debug.Log($"WarmUp round[{i + 1}] end");
            }
        }

        private long RunCase(MethodInfo method, object[] args)
        {
            object obj = Activator.CreateInstance(method.DeclaringType);
            var sw = new Stopwatch();
            sw.Start();
            method.Invoke(obj, args);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        private BenchmarkResult RunAndCreateResult(MethodInfo method, object[] args, int runIteration)
        {
            var br = new BenchmarkResult()
            {
                Method = method,
                Params = args,
                CostTimes = new List<long>(),
            };

            for(int i = 0; i < runIteration; i++)
            {
                br.CostTimes.Add(RunCase(method, args));
            }

            return br;
        }

        private void RunAllBenchmarkCases()
        {
            foreach (var bc in _benchmarkCases)
            {
                System.GC.Collect();
                int runIteration = bc.RunIteration != 0 ? bc.RunIteration : DefaultBenchmarkIteration;
                if (bc.Method.GetParameters().Length != 0)
                {
                    foreach (var args in bc.ParamsList)
                    {
                        _benchmarkResults.Add(RunAndCreateResult(bc.Method, args, runIteration));
                    }
                }
                else
                {
                    _benchmarkResults.Add(RunAndCreateResult(bc.Method, null, runIteration));
                }
            }
        }
    }

}
