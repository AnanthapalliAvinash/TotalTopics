using System;
using System.Collections.Generic;
namespace List
{ 
            public class User
        {
            public int id;
            public String name;
        }
        class Program
        {
            static void Main(string[] args)
            {
            //List<Employee> emp = new List<Employee>();
            List<int> l1 = new List<int>();
                List<int> l2 = new List<int>();
                l1.Add(10);
                l1.Add(11);
                l1.Add(14);
                l2.Add(20);
                l2.InsertRange(1, l1);
                l2.AddRange(l1);
            

                foreach (int i in l2)
                    Console.WriteLine(i);
                List<User> u = new List<User>()
                  {
                      new User {id=11,name="satya" }
                  };
                u.Add(new User { id = 12, name = "gfuyfhfu" });
                u.Add(new User { id = 13, name = "fyyhfyuu" });

                u.Add(new User { id = 23, name = "raj" });
            

                foreach (User n in u)
                {
                    Console.WriteLine("id:{0},name:{1}", n.id, n.name);
                }
            }
    }
}
