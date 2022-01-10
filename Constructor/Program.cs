using System;
using System.Linq;

namespace Constructor
{
    class User
    {
        public string name, location;
        // Default Constructor
        public User()
        {

        }
        public User(int dd)
        {
            
            name = "Suresh Dasari";
            location = "Hyderabad";
        }

        public User(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        static User()
        {
            Console.WriteLine("I am Static Constructor");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // The constructor will be called automatically once the instance of the class created
            User u = new User();
            
            User u1 = new User(10, 20);
            User u2 = u;
            Constructor1 c1 = new Constructor1();
            Console.WriteLine(u.name);
            Console.WriteLine(u.location);
            Console.WriteLine(u2.name);
            Console.WriteLine(u2.location);
        }
    }
}

