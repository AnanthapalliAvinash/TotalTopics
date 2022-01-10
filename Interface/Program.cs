using System;

namespace Interface
{
    interface interface1
    {
        void show();
    }
    class MyClass : interface1
    {
        public void show()
        {
            Console.WriteLine("Welcome to GeeksforGeeks!!!");
        }
        public static void Main(String[] args)
        { 
            MyClass obj1 = new MyClass();
            obj1.show();
        }
    }
}
