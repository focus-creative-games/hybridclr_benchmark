using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTool
{
    public class BenchmarkResult
    {
        public MethodInfo Method { get; set; }

        public object[] Params { get; set; }

        public List<long> CostTimes { get; set; }
    }
}
