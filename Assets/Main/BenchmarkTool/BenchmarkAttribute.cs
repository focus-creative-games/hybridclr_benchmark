using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTool
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class BenchmarkAttribute : Attribute
    {
        public int RunIteration { get; set; }

        public BenchmarkAttribute()
        {
        }
    }
}
