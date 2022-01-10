using System;
using System.Reflection;
namespace Methods
{
    class Method
    {
        public void method(int a,int b)
        {
            int c = a + b;
            
            Console.WriteLine("{0}",c);
        }
        private void Method1()
        {
            int i = 4, j = 2;
            int k = i * j;
            Console.WriteLine("{0}", k);
        }
        public static void Method2(int i,int j)
        {
            int s = i - j;
            Console.WriteLine("{0}", s);

        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Method m1 = new Method();
            m1.method(10, 20);
            Method.Method2(10, 7);
            typeof(Method).GetMethod("Method1", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Method(), null);

        }
    }
}
