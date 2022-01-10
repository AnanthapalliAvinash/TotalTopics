using System;

namespace String_Formatters
{
    
    }
    class Program
    {
        public void number(int a)
    {
        Console.WriteLine(String.Format("{0:D5}",a));
        String s1=a.ToString(PadRight("{5,0}");
    }
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2020, 5, 20);
            TimeSpan hiTime = new TimeSpan(03, 13, 32);
            decimal hiTemp = 24.1m;
            TimeSpan loTime = new TimeSpan(3, 16, 10);
            decimal loTemp = 21.8m;
            DateTime date1 = new DateTime(21, 11,30 );
            string s1 = string.Format("{0:D}", date1);
            string s2 = string.Format("{0:T}", hiTime);

        Program p1 = new Program();
        p1.number(123);
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        // Converts the object to string
        String result1 = String.Format("Temperature on {0:d}:\n{1}: {2} degrees" +
                                           " (hi)\n{3,5}: {4} degrees (lo)", date1,
                                                        hiTime, hiTemp, loTime, loTemp);
            Console.WriteLine(result1);
            Console.WriteLine(String.Format("{0:yy/MM/dd}", date1));
            Console.WriteLine(String.Format("{0:yy/MM/dd}", date1));
        //Console.WriteLine(String.Format("{0:hh/mm/ss}", hiTime));


        Console.ReadLine();
        }
    }

