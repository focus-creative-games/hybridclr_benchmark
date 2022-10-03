using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class FloatArithmetics
    {
        [Benchmark]
        [Params(1000000)]
        public float add_1(int n)
        {
            float a = 1;
            float b = n;
            float c = 2;
            float d = n;
            
            for(int i = 0; i < n; i++)
            {
                a = b + c;
                b = c + d;
                c = d + a;
                d = a + b;
                a = b + c;
                b = c + d;
                c = d + a;
                d = a + b;
                a = b + c;
                b = c + d;
                c = d + a;
                d = a + b;
                a = b + c;
                b = c + d;
                c = d + a;
                d = a + b;
                a = b + c;
                b = c + d;
                c = d + a;
                d = a + b;
            }
            return a + b + c + d;
        }


        [Benchmark]
        [Params(1000000)]
        public float add_2(int n)
        {
            float a = 1;
            float b = n;
            float c = 2;
            float d = n;
            float e = 3;

            for (int i = 0; i < n; i++)
            {
                a = b + c + d + e;
                b = c + d + e + a;
                c = d + e + a + b;
                d = e + a + b + c;
                e = a + b + c + d;
                a = b + c + d + e;
                b = c + d + e + a;
                c = d + e + a + b;
                d = e + a + b + c;
                e = a + b + c + d;
                a = b + c + d + e;
                b = c + d + e + a;
                c = d + e + a + b;
                d = e + a + b + c;
                e = a + b + c + d;
                a = b + c + d + e;
                b = c + d + e + a;
                c = d + e + a + b;
                d = e + a + b + c;
                e = a + b + c + d;
            }
            return a + b + c + d;
        }


        [Benchmark]
        [Params(1000000)]
        public float mul_1(int n)
        {
            float a = 1;
            float b = n;
            float c = 2;
            float d = n;

            for (int i = 0; i < n; i++)
            {
                a = b * c;
                b = c * d;
                c = d * a;
                d = a * b;
                a = b * c;
                b = c * d;
                c = d * a;
                d = a * b;
                a = b * c;
                b = c * d;
                c = d * a;
                d = a * b;
                a = b * c;
                b = c * d;
                c = d * a;
                d = a * b;
                a = b * c;
                b = c * d;
                c = d * a;
                d = a * b;
            }
            return a + b + c + d;
        }


        [Benchmark]
        [Params(1000000)]
        public float mul_2(int n)
        {
            float a = 1;
            float b = n;
            float c = 2;
            float d = n;
            float e = 3;

            for (int i = 0; i < n; i++)
            {
                a = b * c * d * e;
                b = c * d * e * a;
                c = d * e * a * b;
                d = e * a * b * c;
                e = a * b * c * d;
                a = b * c * d * e;
                b = c * d * e * a;
                c = d * e * a * b;
                d = e * a * b * c;
                e = a * b * c * d;
                a = b * c * d * e;
                b = c * d * e * a;
                c = d * e * a * b;
                d = e * a * b * c;
                e = a * b * c * d;
                a = b * c * d * e;
                b = c * d * e * a;
                c = d * e * a * b;
                d = e * a * b * c;
                e = a * b * c * d;
            }
            return a + b + c + d;
        }


        [Benchmark]
        [Params(1000000)]
        public float div_1(int n)
        {
            float a = 1;
            float b = n;
            float c = 2;
            float d = n;

            for (int i = 0; i < n; i++)
            {
                b = c / a;
                c = d / a;
                d = b / a;

                b = c / a;
                c = d / a;
                d = b / a;
                b = c / a;
                c = d / a;
                d = b / a;
                b = c / a;
                c = d / a;
                d = b / a;
                b = c / a;
                c = d / a;
                d = b / a;
                b = c / a;
                c = d / a;
                d = b / a;
                b = c / a;
                c = d / a;
                d = b / a;
                b = c / a;
                c = d / a;
                d = b / a;
                b = c / a;
                c = d / a;
                d = b / a;
                a = a / n + 1;
            }
            return a + b + c + d;
        }
    }
}
