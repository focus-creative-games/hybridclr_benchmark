using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.InterpTypes
{
    public class InterpForNewObj
    {
        public int x;
        public int y;
        public object z;

        public InterpForNewObj(int x, int y, object z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public InterpForNewObj()
        {

        }
    }
}
