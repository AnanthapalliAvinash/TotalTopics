using System;

namespace Structure
{
    class Structure
    {
        
          struct User
          {
            public const string name = "Suresh Dasari";
            public string location;
            public int age;
            public User(string a, int b)
            {
                location = a;
                age = b;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                User u = new User("Hyderabad", 31);
                Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u.location, u.age);
                u.location = "Guntur";
                u.age = 32;
                Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u.location, u.age);
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
    }
}
    

