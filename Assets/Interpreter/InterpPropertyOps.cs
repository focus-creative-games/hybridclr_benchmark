using AOTTypes;
using BenchmarkTool;
using Interpreter.InterpTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class InterpPropertyOps
    {
        [Benchmark]
        [Params(100_0000)]
        public int int_fields(int n)
        {
            var a = new InterpForProperty() { X1_1 = 1, X1_2 = 2, X1_3 = 3 };

            for(int i = 0; i < n; i++)
            {
                a.X1_1 = a.X1_2;
                a.X1_2 = a.X1_3;
                a.X1_3 = a.X1_1;
                a.X1_1 = a.X1_2;
                a.X1_2 = a.X1_3;
                a.X1_3 = a.X1_1;
                a.X1_1 = a.X1_2;
                a.X1_2 = a.X1_3;
                a.X1_3 = a.X1_1;
                a.X1_1 = a.X1_2;
                a.X1_2 = a.X1_3;
                a.X1_3 = a.X1_1;
                a.X1_1 = a.X1_2;
                a.X1_2 = a.X1_3;
                a.X1_3 = a.X1_1;
            }
            return a.X1_1 + a.X1_2 + a.X1_3;
        }



        [Benchmark]
        [Params(100_0000)]
        public UnityEngine.Vector3 vector3_fields(int n)
        {
            var a = new InterpForProperty() { X1_1 = 1, X1_2 = 2, X1_3 = 3 };
            for (int i = 0; i < n; i++)
            {
                a.V3_1 = a.V3_2;
                a.V3_2 = a.V3_3;
                a.V3_3 = a.V3_1;
                a.V3_1 = a.V3_2;
                a.V3_2 = a.V3_3;
                a.V3_3 = a.V3_1;
                a.V3_1 = a.V3_2;
                a.V3_2 = a.V3_3;
                a.V3_3 = a.V3_1;
                a.V3_1 = a.V3_2;
                a.V3_2 = a.V3_3;
                a.V3_3 = a.V3_1;
                a.V3_1 = a.V3_2;
                a.V3_2 = a.V3_3;
                a.V3_3 = a.V3_1;
            }
            return a.V3_1 + a.V3_2 + a.V3_3;
        }
    }
}
