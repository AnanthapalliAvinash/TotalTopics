using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpressions
{ 
    class Dog {
    public string Name { get; set; }
    public int Age { get; set; }
     }
    class Program
    {
        public delegate int MyDelegate(int a);
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>() {
         new Dog { Name = "Rex", Age = 4 },
         new Dog { Name = "Sean", Age = 0 },
         new Dog { Name = "Stacy", Age = 3 }
      };
            var newDogsList = dogs.Where(x=>x.Exists(item=>item.Name=="Rex" && item.Age==4)).ToList();
            foreach (var item in newDogsList)
            {
                Console.WriteLine(item);
            }
            MyDelegate dlgt = x => x * x;         
            int k=dlgt(5);
            Console.WriteLine(k);
            
            Console.ReadLine();
        }
    }
}
