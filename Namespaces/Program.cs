using System;
using CustomNameSpace.Nested;
namespace Namespaces
{
        class Program
        {
            static void Main(string[] args)
            {
                Welcome w = new Welcome();
                w.GreetMessage();
                Console.WriteLine("Press Any Key to Exit..");
                Console.ReadLine();
            }
        }
}
    namespace CustomNameSpace
    {
        namespace Nested
        {
            class Welcome
            {
                public void GreetMessage()
                {
                    Console.WriteLine("Welcome to Tutlane");
                }
            }
        }
    }
    

