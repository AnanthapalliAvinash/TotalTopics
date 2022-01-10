using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegularExpression
{
    class regex1
    {
        public static void Main(String[] args)
        {
            string s = "31-01-2021";
            string s1 = "^(3[01]|[12][0-9]|0[1-9])-(1[0-2]|0[1-9])-([0-9]{4}|[0-9]{2})$";
            string s2= "^(1[0-2]|0[1-9])-(3[01]|[12][0-9]|0[1-9])-([0-9]{4}|[0-9]{2})$";
            string s3 = "^(3[01]|[12][0-9]|0[1-9])-([0-9]{4}|[0-9]{2})-(1[0-2]|0[1-9])$";
            if (Regex.IsMatch(s, s1))
            {
                Console.WriteLine(s);
            }
           else if (Regex.IsMatch(s,s2)|| Regex.IsMatch(s,s3))
            {
                //string s4=string.Format("dd-MM-yyyy:{0}",s);
               
               string ss = Regex.Replace(s, @"\b ^ (1[0 - 2] | 0[1 - 9]) - (3[01] |[12][0 - 9] | 0[1 - 9]) - ([0 - 9]{ 4}|[0 - 9]{ 2})$\b", "${day}/${month}/${year}");
                Console.WriteLine(ss);
            }
        }
    }
}
