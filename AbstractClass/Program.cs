using System;

namespace AbstractClass
{
    class Program
    {
       
          abstract class M1
        {
            public int mul(int a, int b)
            {
                return a * b;
            }
            public abstract int add(int a, int b);
            
        }
        class M2 : M1
        {
           
            public override int add(int a, int b)
            {
                return a + b;
            }
        }
        class test
        {
            static void Main(string[] args)
            {
                M2 ob = new M2();
                Console.WriteLine(ob.add(10, 20));
                Console.WriteLine(ob.mul(2, 3));
                Console.ReadLine();
            }
        }
    }
}
