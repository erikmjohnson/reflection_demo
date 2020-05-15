using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Markup;

namespace ReflectionDemo
{
    class Example2
    {
        public static void ExecutedExample2()
        {
            Type m;
            m = typeof(nclass);
            Console.WriteLine(m.Name);

            foreach (object a in m.GetCustomAttributes())
            {
                Console.WriteLine(a);
            }

            foreach (MethodInfo a in m.GetMethods())
            {
                object[] b = a.GetCustomAttributes(true);

                foreach (Attribute c in b)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    class erik : System.Attribute
    {
        string s1, s2;
        int i1;

        public int ntest;

        public erik(string s, int i)
        {
            s1 = s;
            i1 = i;
        }

        public string name
        {
            get { return s2; }
            set { s2 = value; }
        }
    }

    [erik("hi", 10, name = "hello", ntest = 50)]
    class nclass
    {
        [erik("hi2", 10, name = "hello2", ntest = 50)]
        public void abc() { }
        public int i;

        [erik("hi3", 10, name = "hello3", ntest = 50)]
        public void pqr() { }
    }
}
