using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    public class FieldOps
    {
        [Benchmark]
        [Params(100_0000)]
        public int int_fields(int n)
        {
            var a = new AOTTypes.AOTForFields() { x1 = 1 };
            var b = new AOTTypes.AOTForFields() { x1 = 2 };
            var c = new AOTTypes.AOTForFields() { x1 = 3 };
            for(int i = 0; i < n; i++)
            {
                a.x1 = b.x1;
                b.x1 = c.x1;
                c.x1 = a.x1;
                a.x1 = b.x1;
                b.x1 = c.x1;
                c.x1 = a.x1;
                a.x1 = b.x1;
                b.x1 = c.x1;
                c.x1 = a.x1;
                a.x1 = b.x1;
                b.x1 = c.x1;
                c.x1 = a.x1;
                a.x1 = b.x1;
                b.x1 = c.x1;
                c.x1 = a.x1;
            }
            return a.x1 + b.x1 + c.x1;
        }


        [Benchmark]
        [Params(100_0000)]
        public long long_fields(int n)
        {
            var a = new AOTTypes.AOTForFields() { x2 = 10 };
            var b = new AOTTypes.AOTForFields() { x2 = 20 };
            var c = new AOTTypes.AOTForFields() { x2 = 30 };
            for (int i = 0; i < n; i++)
            {
                a.x2 = b.x2;
                b.x2 = c.x2;
                c.x2 = a.x2;
                a.x2 = b.x2;
                b.x2 = c.x2;
                c.x2 = a.x2;
                a.x2 = b.x2;
                b.x2 = c.x2;
                c.x2 = a.x2;
                a.x2 = b.x2;
                b.x2 = c.x2;
                c.x2 = a.x2;
                a.x2 = b.x2;
                b.x2 = c.x2;
                c.x2 = a.x2;
            }
            return a.x2 + b.x2 + c.x2;
        }


        [Benchmark]
        [Params(100_0000)]
        public object object_fields(int n)
        {
            var a = new AOTTypes.AOTForFields() { x5 = "a" };
            var b = new AOTTypes.AOTForFields() { x5 = "b" };
            var c = new AOTTypes.AOTForFields() { x5 = "c" };
            for (int i = 0; i < n; i++)
            {
                a.x5 = b.x5;
                b.x5 = c.x5;
                c.x5 = a.x5;
                a.x5 = b.x5;
                b.x5 = c.x5;
                c.x5 = a.x5;
                a.x5 = b.x5;
                b.x5 = c.x5;
                c.x5 = a.x5;
                a.x5 = b.x5;
                b.x5 = c.x5;
                c.x5 = a.x5;
                a.x5 = b.x5;
                b.x5 = c.x5;
                c.x5 = a.x5;
            }
            return a.x5 + b.x5 + c.x5;
        }

        [Benchmark]
        [Params(100_0000)]
        public UnityEngine.Vector2 vector2_fields(int n)
        {
            var a = new AOTTypes.AOTForFields() { v2 = new UnityEngine.Vector2(1,2) };
            var b = new AOTTypes.AOTForFields() { v2 = new UnityEngine.Vector2(11, 22) };
            var c = new AOTTypes.AOTForFields() { v2 = new UnityEngine.Vector2(12, 23) };
            for (int i = 0; i < n; i++)
            {
                a.v2 = b.v2;
                b.v2 = c.v2;
                c.v2 = a.v2;
                a.v2 = b.v2;
                b.v2 = c.v2;
                c.v2 = a.v2;
                a.v2 = b.v2;
                b.v2 = c.v2;
                c.v2 = a.v2;
                a.v2 = b.v2;
                b.v2 = c.v2;
                c.v2 = a.v2;
                a.v2 = b.v2;
                b.v2 = c.v2;
                c.v2 = a.v2;
            }
            return a.v2 + b.v2 + c.v2;
        }

        [Benchmark]
        [Params(100_0000)]
        public UnityEngine.Vector3 vector3_fields(int n)
        {
            var a = new AOTTypes.AOTForFields() { v3 = new UnityEngine.Vector3(1, 3) };
            var b = new AOTTypes.AOTForFields() { v3 = new UnityEngine.Vector3(11, 33) };
            var c = new AOTTypes.AOTForFields() { v3 = new UnityEngine.Vector3(13, 33) };
            for (int i = 0; i < n; i++)
            {
                a.v3 = b.v3;
                b.v3 = c.v3;
                c.v3 = a.v3;
                a.v3 = b.v3;
                b.v3 = c.v3;
                c.v3 = a.v3;
                a.v3 = b.v3;
                b.v3 = c.v3;
                c.v3 = a.v3;
                a.v3 = b.v3;
                b.v3 = c.v3;
                c.v3 = a.v3;
                a.v3 = b.v3;
                b.v3 = c.v3;
                c.v3 = a.v3;
            }
            return a.v3 + b.v3 + c.v3;
        }

        [Benchmark]
        [Params(100_0000)]
        public UnityEngine.Vector4 vector4_fields(int n)
        {
            var a = new AOTTypes.AOTForFields() { v4 = new UnityEngine.Vector4(1, 4) };
            var b = new AOTTypes.AOTForFields() { v4 = new UnityEngine.Vector4(11, 44) };
            var c = new AOTTypes.AOTForFields() { v4 = new UnityEngine.Vector4(14, 44) };
            for (int i = 0; i < n; i++)
            {
                a.v4 = b.v4;
                b.v4 = c.v4;
                c.v4 = a.v4;
                a.v4 = b.v4;
                b.v4 = c.v4;
                c.v4 = a.v4;
                a.v4 = b.v4;
                b.v4 = c.v4;
                c.v4 = a.v4;
                a.v4 = b.v4;
                b.v4 = c.v4;
                c.v4 = a.v4;
                a.v4 = b.v4;
                b.v4 = c.v4;
                c.v4 = a.v4;
            }
            return a.v4 + b.v4 + c.v4;
        }
    }
}
