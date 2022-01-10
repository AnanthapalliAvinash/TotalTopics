using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Async1
    {
        public static void Main(String[] args)
        {
            MyMethod();
            LongTask();
            Tasks();
        }
        public static void MyMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Task.Delay(3000).Wait();                
                Console.WriteLine("My Method");
            }
        }
        public static void LongTask()
        {
            Thread.Sleep(2000);
            Console.WriteLine("New Thread");
        }
        public static void Tasks()
        {
            Task.Run(() => Console.WriteLine("Task1"));            
            Task.Run(() => Console.WriteLine("Task2"));
        }
    }
}
