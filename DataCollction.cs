using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection_MathCalc_VotingAge
{
    class DataCollc
    {
        public void DataInput()
        {

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            string ageInput = Console.ReadLine();
            int age;
            while (!int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
                ageInput = Console.ReadLine();
            }
            Console.WriteLine($"Name: {name}, Age: {age}"); 

        }
    }
}
