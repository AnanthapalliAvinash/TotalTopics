using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDemo
{
    class DynamicDemo1
    {
        dynamic Data = 12;
        public int Method(int A, int B)
        {
            return (A + B) * Data;
        }
        class Program
        {
            static void Main(string[] args)
            {
                var v1 = "Hello";
                int v2 = v1.Length;
                Console.WriteLine(v2);
                dynamic d1 = "Hello";
                int d2 = d1.Length;
                Console.WriteLine(d2);
                DynamicDemo1 Obj = new DynamicDemo1();
                dynamic Str = "Your Result Is: ";
                Console.WriteLine(Str + Obj.Method(10,20));
                Console.ReadLine();
            }
        }
    }
    }

