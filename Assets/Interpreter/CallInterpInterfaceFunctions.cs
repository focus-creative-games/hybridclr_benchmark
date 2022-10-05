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
    public class CallInterpInterfaceFunctions
    {
        [Benchmark]
        [Params(100_0000)]
        public int empty(int n)
        {
            AOTForCallInterfaces a = new InterpForCallInterfacesImpl();
            for (int i = 0; i < n; i++)
            {
                a.Empty();
                a.Empty();
                a.Empty();
                a.Empty();
                a.Empty();
                a.Empty();
                a.Empty();
                a.Empty();
                a.Empty();
                a.Empty();
            }
            return 0;
        }


        [Benchmark]
        [Params(100_0000)]
        public int ReturnInt(int n)
        {
            AOTForCallInterfaces a = new InterpForCallInterfacesImpl();
            for (int i = 0; i < n; i++)
            {
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
                a.ReturnInt();
            }
            return 0;
        }


        [Benchmark]
        [Params(100_0000)]
        public int ReturnVector3(int n)
        {
            AOTForCallInterfaces a = new InterpForCallInterfacesImpl();
            for (int i = 0; i < n; i++)
            {
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
                a.ReturnVector3();
            }
            return 0;
        }


        [Benchmark]
        [Params(100_0000)]
        public int CallParamsInt(int n)
        {
            AOTForCallInterfaces a = new InterpForCallInterfacesImpl();
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 0; i < n; i++)
            {
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
                a.Func1(p1, p2, p3, p4, p5);
            }
            return 0;
        }


        [Benchmark]
        [Params(100_0000)]
        public int CallParamsVector3(int n)
        {
            AOTForCallInterfaces a = new InterpForCallInterfacesImpl();
            Vector3 p1 = default;
            for (int i = 0; i < n; i++)
            {
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
                a.Func2(p1, p1, p1, p1);
            }
            return 0;
        }
    }
}
