using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AOTTypes
{
    public interface AOTForCallInterfaces
    {
        void Empty();

        int ReturnInt();

        Vector3 ReturnVector3();

        void Func1(int a, int b, int c, int d, int e);

        void Func2(Vector3 a, Vector3 b, Vector3 c, Vector3 d);
    }

    public class AOTForCallInterfacesImpl : AOTForCallInterfaces
    {
        public void Empty()
        {

        }

        public void Func1(int a, int b, int c, int d, int e)
        {

        }

        public void Func2(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
        {

        }

        public int ReturnInt()
        {
            return 0;
        }

        public Vector3 ReturnVector3()
        {
            return default;
        }
    }
}
