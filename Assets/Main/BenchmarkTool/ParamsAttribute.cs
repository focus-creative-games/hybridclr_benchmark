using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTool
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ParamsAttribute : Attribute
    {
        public object[] Values { get; }

        public ParamsAttribute(params object[] values)
        {
            Values = values;
        }
    }
}
