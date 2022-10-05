using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTTypes
{
    public class AOTForNewObj
    {
        public int x;
        public int y;
        public object z;

        public AOTForNewObj(int x, int y, object z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public AOTForNewObj()
        {

        }
    }
}
