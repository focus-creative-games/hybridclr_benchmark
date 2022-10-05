using AOTTypes;
using InterpTypes;
using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{

    public class NewInterpObjects
    {
        [Benchmark]
        [Params(100000)]
        public void objects_1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
                new InterpForNewObj0();
            }
        }

        [Benchmark]
        [Params(100000)]
        public void objects_2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
                new InterpForNewObj();
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
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
                new InterpForNewObj(a, b, c);
            }
        }
    }
}
