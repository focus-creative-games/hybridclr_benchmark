using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class IntArithmetics
    {
        [Benchmark]
        [Params(1000000)]
        public int add_1(int n)
        {
            int a = 1;
            int b = n;
            int c = 2;
            int d = n;
            
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
        public int add_2(int n)
        {
            int a = 1;
            int b = n;
            int c = 2;
            int d = n;
            int e = 3;

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
        public int mul_1(int n)
        {
            int a = 1;
            int b = n;
            int c = 2;
            int d = n;

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
        public int mul_2(int n)
        {
            int a = 1;
            int b = n;
            int c = 2;
            int d = n;
            int e = 3;

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
        public int div_1(int n)
        {
            int a = 1;
            int b = n;
            int c = 2;
            int d = n;

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
