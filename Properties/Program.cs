using System;

namespace Properties
{
    class User
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                 name = value;
            }

        }
        public  string? location=null;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                 location = value;
            }
            
    }
        
        public int Age { get; set; }

            
            public void GetUserDetails()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Location: " + location);
                Console.WriteLine("Age: " + Age);
        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
              u.Name = "Suresh Dasari";
              u.Location = "Hyderabad";
              u.Age = 30;
              // compile error
              //Console.WriteLine(u.Name);
              u.GetUserDetails();
    }
    }
}
