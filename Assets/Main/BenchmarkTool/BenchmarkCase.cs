using System.Collections.Generic;
using System.Reflection;

namespace BenchmarkTool
{
    public class BenchmarkCase
    {
        public MethodInfo Method { get; set; }

        public List<object[]> ParamsList { get; set; }

        public int RunIteration { get; set; }
    }

}
