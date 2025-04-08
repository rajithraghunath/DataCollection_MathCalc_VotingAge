using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection_MathCalc_VotingAge
{
    class MathCalc
    {
        public void Addition(double a, double b)
        {
            //return a + b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            double ansAdd = Math.Round((a + b),2);
            Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, ansAdd);
        }

        public void Subtraction(double a, double b)
        {
            //return a - b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            double ansSub = Math.Round((a - b), 2);
            Console.WriteLine("The difference of {0} and {1} is: {2}", a, b, ansSub);
        }  

        public void Multiplication(double a, double b)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            double ansMul = Math.Round((a * b), 2);
            Console.WriteLine("The product of {0} and {1} is: {2}", a, b, ansMul);
        }   
        public void Division(double a, double b)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            double ansDiv = Math.Round((a / b), 2);
            double ansRem = Math.Round((a % b), 2);
            Console.WriteLine("\nThe quotient of {0} and {1} is: {2}", a, b, ansDiv);
            Console.WriteLine("The Remainder is: {0}", ansRem);
        }

        public void Power(double a, double b)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            double ansPow = Math.Round((Math.Pow(a, b)), 2);
            Console.WriteLine("The power of {0} and {1} is: {2}", a, b, ansPow);
        }
    }
}
