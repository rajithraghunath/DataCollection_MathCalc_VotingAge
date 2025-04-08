using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection_MathCalc_VotingAge
{
    class Program
    {
        static void Main(string[] args)
        {

            #region DataCollection

            DataCollc dataCollc = new DataCollc();

            #endregion

            #region MathCalc

            Console.ForegroundColor = ConsoleColor.Yellow;
            char userYN = 'Y'; Console.ResetColor();



            while (userYN == 'Y')
            {

                Console.WriteLine("Enter two numbers:");

                Console.ForegroundColor = ConsoleColor.Yellow;
                string inputA = Console.ReadLine();
                int outputA;

                while (!int.TryParse(inputA, out outputA))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                    inputA = Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                string inputB = Console.ReadLine();
                int outputB;

                while (!int.TryParse(inputB, out outputB))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                    inputB = Console.ReadLine();
                }

                Console.ResetColor();

                //int a = Convert.ToInt32(Console.ReadLine());
                //int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nChoose an operation: \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division \n 5. Power");

                Console.ForegroundColor = ConsoleColor.Yellow;
                string choiceInput = Console.ReadLine();
                int choiceOutput;

                while (!int.TryParse(choiceInput, out choiceOutput))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                    choiceInput = Console.ReadLine();
                }

                //int choice = Convert.ToInt32(Console.ReadLine());


                MathCalc mathCalc = new MathCalc();

                switch (choiceOutput)
                {
                    case 1:
                        mathCalc.Addition(outputA, outputB);
                        break;
                    case 2:
                        mathCalc.Subtraction(outputA, outputB);
                        break;
                    case 3:
                        mathCalc.Multiplication(outputA, outputB);
                        break;
                    case 4:
                        mathCalc.Division(outputA, outputB);
                        break;
                    case 5:
                        mathCalc.Power(outputA, outputB);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nDo you try repeat the Mathods? Press Y/N"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                userYN = Convert.ToChar(Console.ReadLine()); Console.ResetColor();

                if (userYN == 'Y' || userYN == 'y')
                {
                    Console.ResetColor();
                    userYN = 'Y';
                    Console.WriteLine("\n");
                }

                if (userYN == 'N' || userYN == 'n')
                {
                    Console.WriteLine("Thank you for using the program. Press any key to Exit!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                #endregion
            }
        }

    }
}
          

