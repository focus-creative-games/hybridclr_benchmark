using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AOTTypes
{
    public abstract class AOTForCallAbstracts
    {
        public abstract void Empty();

        public abstract int ReturnInt();

        public abstract Vector3 ReturnVector3();

        public abstract void Func1(int a, int b, int c, int d, int e);

        public abstract void Func2(Vector3 a, Vector3 b, Vector3 c, Vector3 d);
    }

    public class AOTForCallAbstractsImpl : AOTForCallAbstracts
    {
        public override void Empty()
        {

        }

        public override void Func1(int a, int b, int c, int d, int e)
        {

        }

        public override void Func2(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
        {

        }

        public override int ReturnInt()
        {
            return 0;
        }

        public override Vector3 ReturnVector3()
        {
            return default;
        }
    }
}
