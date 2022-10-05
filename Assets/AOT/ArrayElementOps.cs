using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Benchmarks
{
    internal class ArrayElementOps
    {
        [Benchmark]
        [Params(10_0000)]
        public int int_array(int n)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var brr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var crr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < n; i++)
            {
                int j = i % 8;
                brr[j] = i;
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
            }
            return arr[1] + brr[1] + crr[1];
        }


        [Benchmark]
        [Params(10_0000)]
        public string string_array(int n)
        {
            var arr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            var brr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            var crr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            for (int i = 0; i < n; i++)
            {
                int j = i % 8;
                brr[j] = "abc";
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
            }
            return arr[1] + brr[1] + crr[1];
        }

        [Benchmark]
        [Params(10_0000)]
        public Vector3 vector3_array(int n)
        {
            var arr = new Vector3[8];
            var brr = new Vector3[8];
            var crr = new Vector3[8];
            var v = new Vector3(10, 20, 30);
            for (int i = 0; i < n; i++)
            {
                int j = i % 8;
                brr[j] = v;
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
                arr[j] = brr[0];
                brr[j] = crr[0];
                crr[j] = arr[j];
            }
            return arr[1] + brr[1] + crr[1];
        }
    }
}
