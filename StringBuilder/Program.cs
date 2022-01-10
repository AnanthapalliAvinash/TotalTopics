using System;
using System.Text;

namespace Tutlane
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Suresh");
            sb.Append(", Rohini");
            sb.Append(", Trishika");
            sb.AppendLine();
            sb.Append("Welcome to Tutlane");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("Welcome World");
            sb1.Insert(8, "to Tutlane ");
            Console.WriteLine("Insert String: " + sb1);

            StringBuilder sb2 = new StringBuilder("Welcome to Tutlane");
            sb2.Remove(8, 3);
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder("Welcome to Tutlane World");
            sb3.Replace("Tutlane", "C#");
            Console.WriteLine(sb3);
            Console.ReadLine();
        }
    }
}