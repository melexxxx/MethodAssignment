using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            // Integer calculation
            Console.Write("Enter an integer: ");
            string intInput = Console.ReadLine();
            if (int.TryParse(intInput, out int result1))
            {
                int finalResult1 = mathOps.Calculate(result1);
                Console.WriteLine("Integer Result: " + finalResult1);
            }
            else
            {
                Console.WriteLine("Invalid input: Could not convert to integer");
            }

            // Decimal calculation
            Console.Write("Enter a decimal number: ");
            string decimalInput = Console.ReadLine();
            if (decimal.TryParse(decimalInput, out decimal result2))
            {
                int finalResult2 = mathOps.Calculate(result2);
                Console.WriteLine("Decimal Result: " + finalResult2);
            }
            else
            {
                Console.WriteLine("Invalid input: Could not convert to decimal");
            }

            // String calculation
            Console.Write("Enter a string number: ");
            string stringInput = Console.ReadLine();
            int result3 = mathOps.Calculate(stringInput);
            Console.WriteLine("String Result: " + result3);
            Console.ReadLine();

        }
        
    }
}