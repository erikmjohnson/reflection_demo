using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
    class Example1
    {
        public static void ExecuteMain()
        {
            Type m1;
            m1 = typeof(int);  // system.int32
            System.Console.WriteLine(m1.Name + " " + m1.FullName);

            m1 = typeof(System.Int32);  // system.int32
            System.Console.WriteLine(m1.Name + " " + m1.FullName);

            m1 = typeof(Example1);  // system.int32
            System.Console.WriteLine(m1.Name + " " + m1.FullName);
        }

        public static void ExecuteMain1()
        {
            Type m1 = typeof(Example1); // user defined type
            MemberInfo[] n;
            n = m1.GetMembers();
            Console.WriteLine(n.Length);
            
            foreach(MemberInfo a in n) 
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
