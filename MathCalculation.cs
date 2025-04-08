using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection_MathCalc_VotingAge
{
    class MathCalc
    {
        public void Addition(int a, int b)
        {

            //return a + b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, a + b);
        }

        public void Subtraction(int a, int b)
        {
            //return a - b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The difference of {0} and {1} is: {2}", a, b, a - b);
        }  

        public void Multiplication(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The product of {0} and {1} is: {2}", a, b, a * b);
        }   
        public void Division(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThe quotient of {0} and {1} is: {2}", a, b, a / b);
            Console.WriteLine("The Remainder is ", a % b);

        }

        public void Power(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The power of {0} and {1} is: {2}", a, b, Math.Pow(a, b));
        }
    }
}
