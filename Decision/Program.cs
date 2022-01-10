using System;

namespace Decision
{
    class name
    {
        public void decision()
        {
            int x = 20, y = 10;
            if (x >= 10)
            {
                Console.WriteLine("x is Greater than 10");
            }
            if (y <= 5)
            {
                Console.WriteLine("y is less than or equals to 5");
            }
        }
        public void decision1()
        {
            int x = 20, y = 10;
            if (x >= 10)
            {
                Console.WriteLine("x is Greater than 10");
            }
            else
            {
                Console.WriteLine("y is less than or equals to 5");
            }
        }
        public void decision2()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x value equals to 10");
            }
            else if (x > 10)
            {
                Console.WriteLine("x value greater than 10");
            }
            else
            {
                Console.WriteLine("x value less than 10");
            }
        }
        public void decision3()
        {
            int x = 5, y = 20;
            if (x > y)
            {
                if (x >= 10)
                {
                    Console.WriteLine("x value greater than or equal to 10");
                }
                else
                {
                    Console.WriteLine("x value less than 10");
                }
            }
            else
            {
                if (y <= 20)
                {
                    Console.WriteLine("y value less than or equal to 20");
                }
                else
                {
                    Console.WriteLine("y value greater than 20");
                }

            }
        }
        public void conditional()
        {
            int x = 5, y = 20;
            string result;
            //Ternary Operator (?:)
            result = (x > y) ? "x value greater than y" : "x value less than y";
            Console.WriteLine(result);
        }
        public void Switch(){
          int x = 10,y=5;
             switch (x)
             {
                 case 10:
                     Console.WriteLine("x value is 10");
                    switch (y)
                    {
                        case 5:
                            Console.WriteLine("Nested Switch Value: 5");
                            switch (y - 2)
                            {
                                case 3:
                                    Console.WriteLine("Another Nested Switch Value: 3");
                                    break;
                            }
                            break;
                    }
                    
                    break;
                case 15:
                     Console.WriteLine("x value is 15");
                     break;
                 case 20:
                     Console.WriteLine("x value is 20");
                     break;
                 default:
                     Console.WriteLine("Not Known");
                     break;
             }
}
}
    class Program
    {
        static void Main(string[] args)
        {
            name n = new name();
            n.decision();
            n.decision1();
            n.decision2();
            n.decision3();
            n.conditional();
            n.Switch();
            }
    }
}
