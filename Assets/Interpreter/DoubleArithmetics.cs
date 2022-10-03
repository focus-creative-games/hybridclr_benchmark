using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class DoubleArithmetics
    {
        [Benchmark]
        [Params(1000000)]
        public double add_1(int n)
        {
            double a = 1;
            double b = n;
            double c = 2;
            double d = n;

            for (int i = 0; i < n; i++)
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
        public double add_2(int n)
        {
            double a = 1;
            double b = n;
            double c = 2;
            double d = n;
            double e = 3;

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
        public double mul_1(int n)
        {
            double a = 1;
            double b = n;
            double c = 2;
            double d = n;

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
        public double mul_2(int n)
        {
            double a = 1;
            double b = n;
            double c = 2;
            double d = n;
            double e = 3;

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
        public double div_1(int n)
        {
            double a = 1;
            double b = n;
            double c = 2;
            double d = n;

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
