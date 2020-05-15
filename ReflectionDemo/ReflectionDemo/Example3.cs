using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
    class Example3
    {
        public static void ExecuteExample3()
        {
            Type m;
            m = typeof(erikj);

            Console.WriteLine(m.Name);

            foreach (object a in m.GetCustomAttributes())
            {
                Console.WriteLine(a);
            }

            foreach (MethodInfo a in m.GetMethods())
            {
                object[] b = a.GetCustomAttributes(true);

                foreach(Attribute c in b)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    class erikj : System.Attribute
    {
        string s1, s2;
        int i1;

        public int johnson;

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
