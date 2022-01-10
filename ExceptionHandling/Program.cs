using System;

namespace TutlaneExamples
{
    class Program
    {
        static void Main(string[] args)
        {           
            try
            {                
                string name = null;
                try
                {
                    if (name.Length > 0) 
                    {
                        Console.WriteLine("Name: " + name);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    int[] n = new int[5] { 66, 33, 56, 23, 81 };                    
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine("Element[{0}] = {1}", j, n[j]);
                    }
                    Console.ReadKey();
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("Enter x value:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y value:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(x / y);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception: {0}", ex);
                //throw new DivideByZeroException("The number cannot divided by zero");
            }
            finally
            {
                Console.WriteLine("Finally Block.");
            }
            Console.ReadLine();
        }
    }
}