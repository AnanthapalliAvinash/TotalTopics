using System;

namespace Enum1
{
    class Program
    {    
            enum Week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Week Enumeration Values");
            foreach (string w in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(w);
            }
            int a = (int)Week.Sunday;
            int b = (int)Week.Monday;
            int c = (int)Week.Tuesday;
            Console.WriteLine(Week.Sunday);
            Console.WriteLine(Week.Monday);
            Console.WriteLine("Sunday: {0},{1}", Week.Sunday, a);
            Console.WriteLine("Monday: {0}", b);
            Console.WriteLine("Tuesday: {0}", c);
            Console.WriteLine("\nPress Any Key to Exit..");
            Console.ReadLine();
        }
    }
    }

