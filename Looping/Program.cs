using System;

namespace Looping
{
    class Loops
    {
        public void forloop()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    
                    Console.WriteLine(" {0},{1} ", +i,+j);
                }
            }
        }
        public void whileloop()
        {
            int k = 1;
            while (k <= 4)
            {
                Console.WriteLine("k value: {0}", k);
                k++;
            }
        }
        public void dowhile()
        {
            int l = 1;
            do
            {
                Console.WriteLine("l value: {0}", l);
                l++;
            } while (l <= 4);
        }
        public void foreachloop()
        {
            string[] names = new string[3] { "Suresh Dasari", "Rohini Alavala", "Trishika Dasari" };
            foreach (string name in names)
            {
                
                Console.WriteLine(name);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Loops l1 = new Loops();
            l1.forloop();
            l1.whileloop();
            l1.dowhile();
            l1.foreachloop();
        }
    }
}


