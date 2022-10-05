using AOTTypes;
using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    public class StaticFieldOps
    {
        [Benchmark]
        [Params(100_0000)]
        public int int_fields(int n)
        {
            for(int i = 0; i < n; i++)
            {
                AOTForStaticFields.x1_1 = AOTForStaticFields.x1_2;
                AOTForStaticFields.x1_2 = AOTForStaticFields.x1_3;
                AOTForStaticFields.x1_3 = AOTForStaticFields.x1_1;
                AOTForStaticFields.x1_1 = AOTForStaticFields.x1_2;
                AOTForStaticFields.x1_2 = AOTForStaticFields.x1_3;
                AOTForStaticFields.x1_3 = AOTForStaticFields.x1_1;
                AOTForStaticFields.x1_1 = AOTForStaticFields.x1_2;
                AOTForStaticFields.x1_2 = AOTForStaticFields.x1_3;
                AOTForStaticFields.x1_3 = AOTForStaticFields.x1_1;
                AOTForStaticFields.x1_1 = AOTForStaticFields.x1_2;
                AOTForStaticFields.x1_2 = AOTForStaticFields.x1_3;
                AOTForStaticFields.x1_3 = AOTForStaticFields.x1_1;
                AOTForStaticFields.x1_1 = AOTForStaticFields.x1_2;
                AOTForStaticFields.x1_2 = AOTForStaticFields.x1_3;
                AOTForStaticFields.x1_3 = AOTForStaticFields.x1_1;
            }
            return AOTForStaticFields.x1_1 + AOTForStaticFields.x1_2 + AOTForStaticFields.x1_3;
        }


        [Benchmark]
        [Params(100_0000)]
        public long long_fields(int n)
        {
            for (int i = 0; i < n; i++)
            {
                AOTForStaticFields.x2_1 = AOTForStaticFields.x2_2;
                AOTForStaticFields.x2_2 = AOTForStaticFields.x2_3;
                AOTForStaticFields.x2_3 = AOTForStaticFields.x2_1;
                AOTForStaticFields.x2_1 = AOTForStaticFields.x2_2;
                AOTForStaticFields.x2_2 = AOTForStaticFields.x2_3;
                AOTForStaticFields.x2_3 = AOTForStaticFields.x2_1;
                AOTForStaticFields.x2_1 = AOTForStaticFields.x2_2;
                AOTForStaticFields.x2_2 = AOTForStaticFields.x2_3;
                AOTForStaticFields.x2_3 = AOTForStaticFields.x2_1;
                AOTForStaticFields.x2_1 = AOTForStaticFields.x2_2;
                AOTForStaticFields.x2_2 = AOTForStaticFields.x2_3;
                AOTForStaticFields.x2_3 = AOTForStaticFields.x2_1;
                AOTForStaticFields.x2_1 = AOTForStaticFields.x2_2;
                AOTForStaticFields.x2_2 = AOTForStaticFields.x2_3;
                AOTForStaticFields.x2_3 = AOTForStaticFields.x2_1;
            }
            return AOTForStaticFields.x2_1 + AOTForStaticFields.x2_2 + AOTForStaticFields.x2_3;
        }


        [Benchmark]
        [Params(100_0000)]
        public object object_fields(int n)
        {
            for (int i = 0; i < n; i++)
            {
                AOTForStaticFields.x5_1 = AOTForStaticFields.x5_2;
                AOTForStaticFields.x5_2 = AOTForStaticFields.x5_3;
                AOTForStaticFields.x5_3 = AOTForStaticFields.x5_1;
                AOTForStaticFields.x5_1 = AOTForStaticFields.x5_2;
                AOTForStaticFields.x5_2 = AOTForStaticFields.x5_3;
                AOTForStaticFields.x5_3 = AOTForStaticFields.x5_1;
                AOTForStaticFields.x5_1 = AOTForStaticFields.x5_2;
                AOTForStaticFields.x5_2 = AOTForStaticFields.x5_3;
                AOTForStaticFields.x5_3 = AOTForStaticFields.x5_1;
                AOTForStaticFields.x5_1 = AOTForStaticFields.x5_2;
                AOTForStaticFields.x5_2 = AOTForStaticFields.x5_3;
                AOTForStaticFields.x5_3 = AOTForStaticFields.x5_1;
                AOTForStaticFields.x5_1 = AOTForStaticFields.x5_2;
                AOTForStaticFields.x5_2 = AOTForStaticFields.x5_3;
                AOTForStaticFields.x5_3 = AOTForStaticFields.x5_1;
            }
            return AOTForStaticFields.x5_1 + AOTForStaticFields.x5_2 + AOTForStaticFields.x5_3;
        }

        [Benchmark]
        [Params(100_0000)]
        public UnityEngine.Vector2 vector2_fields(int n)
        {
            for (int i = 0; i < n; i++)
            {
                AOTForStaticFields.v2_1 = AOTForStaticFields.v2_2;
                AOTForStaticFields.v2_2 = AOTForStaticFields.v2_3;
                AOTForStaticFields.v2_3 = AOTForStaticFields.v2_1;
                AOTForStaticFields.v2_1 = AOTForStaticFields.v2_2;
                AOTForStaticFields.v2_2 = AOTForStaticFields.v2_3;
                AOTForStaticFields.v2_3 = AOTForStaticFields.v2_1;
                AOTForStaticFields.v2_1 = AOTForStaticFields.v2_2;
                AOTForStaticFields.v2_2 = AOTForStaticFields.v2_3;
                AOTForStaticFields.v2_3 = AOTForStaticFields.v2_1;
                AOTForStaticFields.v2_1 = AOTForStaticFields.v2_2;
                AOTForStaticFields.v2_2 = AOTForStaticFields.v2_3;
                AOTForStaticFields.v2_3 = AOTForStaticFields.v2_1;
                AOTForStaticFields.v2_1 = AOTForStaticFields.v2_2;
                AOTForStaticFields.v2_2 = AOTForStaticFields.v2_3;
                AOTForStaticFields.v2_3 = AOTForStaticFields.v2_1;
            }
            return AOTForStaticFields.v2_1 + AOTForStaticFields.v2_2 + AOTForStaticFields.v2_3;
        }

        [Benchmark]
        [Params(100_0000)]
        public UnityEngine.Vector3 vector3_fields(int n)
        {
            for (int i = 0; i < n; i++)
            {
                AOTForStaticFields.v3_1 = AOTForStaticFields.v3_2;
                AOTForStaticFields.v3_2 = AOTForStaticFields.v3_3;
                AOTForStaticFields.v3_3 = AOTForStaticFields.v3_1;
                AOTForStaticFields.v3_1 = AOTForStaticFields.v3_2;
                AOTForStaticFields.v3_2 = AOTForStaticFields.v3_3;
                AOTForStaticFields.v3_3 = AOTForStaticFields.v3_1;
                AOTForStaticFields.v3_1 = AOTForStaticFields.v3_2;
                AOTForStaticFields.v3_2 = AOTForStaticFields.v3_3;
                AOTForStaticFields.v3_3 = AOTForStaticFields.v3_1;
                AOTForStaticFields.v3_1 = AOTForStaticFields.v3_2;
                AOTForStaticFields.v3_2 = AOTForStaticFields.v3_3;
                AOTForStaticFields.v3_3 = AOTForStaticFields.v3_1;
                AOTForStaticFields.v3_1 = AOTForStaticFields.v3_2;
                AOTForStaticFields.v3_2 = AOTForStaticFields.v3_3;
                AOTForStaticFields.v3_3 = AOTForStaticFields.v3_1;
            }
            return AOTForStaticFields.v3_1 + AOTForStaticFields.v3_2 + AOTForStaticFields.v3_3;
        }

        [Benchmark]
        [Params(100_0000)]
        public UnityEngine.Vector4 vector4_fields(int n)
        {
            for (int i = 0; i < n; i++)
            {
                AOTForStaticFields.v4_1 = AOTForStaticFields.v4_2;
                AOTForStaticFields.v4_2 = AOTForStaticFields.v4_3;
                AOTForStaticFields.v4_3 = AOTForStaticFields.v4_1;
                AOTForStaticFields.v4_1 = AOTForStaticFields.v4_2;
                AOTForStaticFields.v4_2 = AOTForStaticFields.v4_3;
                AOTForStaticFields.v4_3 = AOTForStaticFields.v4_1;
                AOTForStaticFields.v4_1 = AOTForStaticFields.v4_2;
                AOTForStaticFields.v4_2 = AOTForStaticFields.v4_3;
                AOTForStaticFields.v4_3 = AOTForStaticFields.v4_1;
                AOTForStaticFields.v4_1 = AOTForStaticFields.v4_2;
                AOTForStaticFields.v4_2 = AOTForStaticFields.v4_3;
                AOTForStaticFields.v4_3 = AOTForStaticFields.v4_1;
                AOTForStaticFields.v4_1 = AOTForStaticFields.v4_2;
                AOTForStaticFields.v4_2 = AOTForStaticFields.v4_3;
                AOTForStaticFields.v4_3 = AOTForStaticFields.v4_1;
            }
            return AOTForStaticFields.v4_1 + AOTForStaticFields.v4_2 + AOTForStaticFields.v4_3;
        }
    }
}
