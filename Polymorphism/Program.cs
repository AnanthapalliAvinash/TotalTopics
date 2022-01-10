using System;

namespace Polymorphism
{
    public class BClass
    {
        public virtual void GetInfo(int a,int b)
        {
            int s = a + b;
            Console.WriteLine("sum:{0}",s);
        }
    }
    // Derived Class
    public class DClass : BClass
    {
        public override void GetInfo(int a,int b)
        {
            int d = a / b;
            Console.WriteLine("div{0}",d);
        }
    }
    public class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
            DClass d = new DClass();
            d.GetInfo(10,20);
            BClass b = new BClass();
            b.GetInfo(30,40);
        }
    }
}
