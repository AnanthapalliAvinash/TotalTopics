using System;

namespace Arrays
{
    class Arrays
    {
        public void singlearray()
        {
            int[] array = new int[5] { 1, 2, 5, 4, 3 };
            string[] a = new string[5];
            Console.WriteLine("enter array");
            for(int i = 0; i <5; i++)
            {
                a[i] = (Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Array.Sort(array);
            Console.WriteLine("---Elements After Sort---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(array);
            Console.WriteLine("---Elements After Reverse---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        public void doublearray()
        {
            int[,] array2D = new int[3, 2] { { 4, 5 }, { 5, 0 }, { 3, 1 } };
            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            Console.WriteLine("---Two Dimensional Array Elements---");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, array2D[i, j]);
                }
            }
            Console.WriteLine("---Three Dimensional Array Elements---");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, array3D[i, j, k]);
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arrays a = new Arrays();
            a.singlearray();
            a.doublearray();
        }
    }
}
