using AOTTypes;
using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{

    public class NewAOTObjects
    {
        [Benchmark]
        [Params(100000)]
        public void objects_0(int n)
        {
            for(int i = 0; i < n; i++)
            {
                new object();
                new object();
                new object();
                new object();
                new object();
                new object();
                new object();
                new object();
                new object();
                new object();
            }
        }

        [Benchmark]
        [Params(100000)]
        public void objects_1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
                new AOTForNewObj0();
            }
        }

        [Benchmark]
        [Params(100000)]
        public void objects_2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
                new AOTForNewObj();
            }
        }

        [Benchmark]
        [Params(100000)]
        public void objects_3(int n)
        {
            int a = 10;
            int b = 20;
            object c = "abc";
            for (int i = 0; i < n; i++)
            {
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
                new AOTForNewObj(a, b, c);
            }
        }
    }
}
