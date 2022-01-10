using System;

namespace AbstractClass
{
    class Program
    {

        abstract class M1
        {
            public M1()
            {
                Console.WriteLine("this is constractor");
            }
            public   int add(int a, int b)
            {
                return a + b;
            }

            public abstract int mul(int a, int b);

        }
        class M2 : M1
        {

           
            public override int mul(int a, int b)
            {
                return a * b;
            }
        }
        class test
        {
            static void Main(string[] args)
            {
                M1 ob1 = new M2();
                //M2 ob = new M2();
                
                Console.WriteLine(ob1.add(10, 20));
                //Console.WriteLine(ob.mul(2, 3));
                Console.ReadLine();
            }
        }
    }
}