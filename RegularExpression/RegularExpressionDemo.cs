using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class RegularExpressionDemo
    {
        public static void Main(String[] args)
        {
            string input = "A12";
            string input1 = "A12 B24 C67 DC";
           
            Regex re = new Regex(@"[a-zA-Z]\d\d");
            Match m = re.Match(input);
            if (re.IsMatch(input))
            {
                Console.WriteLine(m.Value);
            }
           
            Console.WriteLine(re.IsMatch(input1));
            Regex re1 = new Regex(@"[a-zA-Z]\d\d");
            MatchCollection mc = re1.Matches(input1);
            foreach (Match mt in mc)
            {
                Console.WriteLine(mt);
            }
            Console.WriteLine(mc.Count);
        }
    }
}
