using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegularExpression
{
    class Program
    {
        public class Regular
        {
            public static string Name = "^[RR]{0,1}[A-Z]{1}[A-Za-z]{6,}$";
            public static string MobileNo = "^[6-9]{1}[0-9]{9}$";
            public static string Email = "^[a-z0-9A-Z]+[.]{0,1}[a-zA-Z0-9]+[@]+[a-z]{5,}[.]+[a-zA-Z]{2,3}$";
            public static string Password = "^[A-Z]{1}[a-z0-9@#$%^&*]{8,}$";
            public static string address = "^[0-9]+[-/]+[0-9]+[-/]$";
            public bool NameValidation()
            {
                return Regex.IsMatch("Avinash",Name);
            }
            public bool MobileValidation()
            {
                return Regex.IsMatch("+916281344204",MobileNo);
            }
            public bool EmailValidation()
            {
                return Regex.IsMatch("avinashananthapalli@gmail.com", Email);
            }
            public bool PasswordValidation()
            {
                return Regex.IsMatch("avinash@555#", Password);
            }

        }
        static void Main(string[] args)
        {
            Regular r = new Regular();
            bool k1=r.NameValidation();
            Console.WriteLine(k1);
            bool k2 = r.MobileValidation();
            Console.WriteLine(k2);
            bool k3 = r.EmailValidation();
            Console.WriteLine(k3);
            bool k4 = r.PasswordValidation();
            Console.WriteLine(k4);
        }
    }
}
