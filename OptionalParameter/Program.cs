using System;
using System.Runtime.InteropServices;

namespace OptionalParameter
{
    class Program
    {
        public static void AddNumbers(int n1,[Optional] int n2)
        {
            
        int result=n1 + n2;
            
            Console.WriteLine("sum is {0}",result);
        }
        static void Main(string[] args)
        {
            AddNumbers(10,30);
           
            Console.ReadLine();
        }
        
    }
}
