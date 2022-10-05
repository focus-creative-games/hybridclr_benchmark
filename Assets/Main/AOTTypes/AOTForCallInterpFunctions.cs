using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AOTTypes
{
    public static class AOTForCallInterpFunctions
    {
        public static void CallEmpty(AOTForCallAbstracts o, int n)
        {
            for(int i = 0; i < n; i++)
            {
                o.Empty();
                o.Empty();
                o.Empty();
                o.Empty();
                o.Empty();
                o.Empty();
                o.Empty();
                o.Empty();
                o.Empty();
                o.Empty();
            }
        }


        public static void CallReturnInt(AOTForCallAbstracts o, int n)
        {
            for (int i = 0; i < n; i++)
            {
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
                o.ReturnInt();
            }
        }


        public static void CallReturnVector3(AOTForCallAbstracts o, int n)
        {
            for (int i = 0; i < n; i++)
            {
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
                o.ReturnVector3();
            }
        }


        public static void CallParamsInt(AOTForCallAbstracts o, int n)
        {
            int a = n;
            for (int i = 0; i < n; i++)
            {
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
                o.Func1(a, a, a, a, a);
            }
        }


        public static void CallParamsVector3(AOTForCallAbstracts o, int n)
        {
            Vector3 a = Vector3.one;
            for (int i = 0; i < n; i++)
            {
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
                o.Func2(a, a, a, a);
            }
        }
    }
}
