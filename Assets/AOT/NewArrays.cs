using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Benchmarks
{
    public class NewArrays
    {
        [Benchmark]
        [Params(10_0000)]
        public void int_array(int n)
        {
            for(int i = 0; i < n; i++)
            {
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
                _ = new int[10];
            }
        }


        [Benchmark]
        [Params(10_0000)]
        public void vector3_array(int n)
        {
            for (int i = 0; i < n; i++)
            {
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
                _ = new Vector3[10];
            }
        }
    }
}
