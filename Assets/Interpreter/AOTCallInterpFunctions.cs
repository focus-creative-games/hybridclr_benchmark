using AOTTypes;
using BenchmarkTool;
using InterpTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Benchmarks
{
    public class AOTCallInterpFunctions
    {
        [Benchmark]
        [Params(100_0000)]
        public int empty(int n)
        {
            var a = new InterpForCallAbstractsImpl();
            AOTForCallInterpFunctions.CallEmpty(a, n);
            return 0;
        }


        [Benchmark]
        [Params(100_0000)]
        public int ReturnInt(int n)
        {
            var a = new InterpForCallAbstractsImpl();
            AOTForCallInterpFunctions.CallReturnInt(a, n);
            return 0;
        }


        [Benchmark]
        [Params(100_0000)]
        public int ReturnVector3(int n)
        {
            var a = new InterpForCallAbstractsImpl();
            AOTForCallInterpFunctions.CallReturnVector3(a, n);
            return 0;
        }



        [Benchmark]
        [Params(100_0000)]
        public int CallParamsInt(int n)
        {
            var a = new InterpForCallAbstractsImpl();
            AOTForCallInterpFunctions.CallParamsInt(a, n);
            return 0;
        }


        [Benchmark]
        [Params(100_0000)]
        public int CallParamsVector3(int n)
        {
            var a = new InterpForCallAbstractsImpl();
            AOTForCallInterpFunctions.CallParamsVector3(a, n);
            return 0;
        }
    }
}
