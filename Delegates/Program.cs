using System;
using System.IO;
namespace Delegates
{
    //public delegate void SampleDelegate(int a, int b);
    class MathOperations
    {
        static int n = 3;
        public int Add(int a, int b)
        {
            return n+=a + b;
        }
        public static void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract Result: {0}", n+=(x - y));
        }
        public static bool validstring(String str) 
        {
            if (str.Length > 6)
                return true; 
            return false;

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Generic Delegates Example****");
            MathOperations m = new MathOperations();
           Func<int,int,int> obj=m.Add;
            int s = obj.Invoke(1,2);
            Console.WriteLine(s);
            Action<int,int> obj1 = MathOperations.Subtract;
            obj1.Invoke(10,4);
            Predicate<String> obj2 = MathOperations.validstring;
            bool s1 = obj2.Invoke("welcome");
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
