using System;
using System.Collections.Generic;
using System.Linq;
namespace Ienumarable
{
    class Program
    {
        public int Id { get; set; }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Id = 10;

            int[] arr = { 19, 3, 47, 89, 56 };
            IEnumerable<int> result = Enumerable.Where(arr,x => x < 20);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            IQueryable<int> result1 = arr.AsQueryable().Where(x => x > 20);
            foreach (var i in result1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
