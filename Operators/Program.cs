using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithematic Operators");
            int result;
            int x = 20, y = 10;
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
            
            Console.WriteLine("Relational Operators");
            bool result1;
            result1 = (x == y);
            Console.WriteLine("Equal to Operator: " + result1);
            result1 = (x > y);
            Console.WriteLine("Greater than Operator: " + result1);
            result1 = (x <= y);
            Console.WriteLine("Lesser than or Equal to: " + result1);
            result1 = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result1);
            Console.WriteLine("Logical Operators");
            bool a = true, result2;
            // AND operator
            result2 = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result2);
            // OR operator
            result2 = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result2);
            //NOT operator
            result2 = !a;
            Console.WriteLine("NOT Operator: " + result2);
            
            Console.WriteLine("Bitwise Operators");
            int result3 = x & y;
            Console.WriteLine("Bitwise AND: " + result3);
            result3 = x | y;
            Console.WriteLine("Bitwise OR: " + result3);
            result3 = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result3);
            result3 = ~x;
            Console.WriteLine("Bitwise Complement: " + result3);
            result3 = x << 2;
            Console.WriteLine("Bitwise Left Shift: " + result3);
            result3 = x >> 2;
            Console.WriteLine("Bitwise Right Shift: " + result3);
            Console.WriteLine("Assignment Operators");
            x += 10;
            Console.WriteLine("Add Assignment: " + x);
            x *= 4;
            Console.WriteLine("Multiply Assignment: " + x);
            x %= 7;
            Console.WriteLine("Modulo Assignment: " + x);
            x &= 10;
            Console.WriteLine("Bitwise And Assignment: " + x);
            x ^= 12;
            Console.WriteLine("Bitwise XOR Assignment: " + x);
            x >>= 3;
            Console.WriteLine("Right Shift Assignment: " + x);

            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
