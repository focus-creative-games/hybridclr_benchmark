using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    public class LongArithmetics
    {
        [Benchmark]
        [Params(1000000)]
        public long add_1(long n)
        {
            long a = 1;
            long b = n;
            long c = 2;
            long d = n;
            
            for(long i = 0; i < n; i++)
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
        public long add_2(long n)
        {
            long a = 1;
            long b = n;
            long c = 2;
            long d = n;
            long e = 3;

            for (long i = 0; i < n; i++)
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
        public long mul_1(long n)
        {
            long a = 1;
            long b = n;
            long c = 2;
            long d = n;

            for (long i = 0; i < n; i++)
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
        public long mul_2(long n)
        {
            long a = 1;
            long b = n;
            long c = 2;
            long d = n;
            long e = 3;

            for (long i = 0; i < n; i++)
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
        public long div_1(long n)
        {
            long a = 1;
            long b = n;
            long c = 2;
            long d = n;

            for (long i = 0; i < n; i++)
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
