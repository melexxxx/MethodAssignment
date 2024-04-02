using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class MathOperations
    {
        // Method 1: Handles integers
        public int Calculate(int number)
        {
            // Example operation: Multiply by 5
            return number * 5;
        }

        // Method 2: Handles decimals
        public int Calculate(decimal number)
        {
            // Example operation: Divide by 2 and round down
            return (int)Math.Floor(number / 2);
        }

        // Method 3: Handles strings (converts to int if possible)
        public int Calculate(string numberString)
        {
            int number;
            if (int.TryParse(numberString, out number))
            {
                // Example operation: Add 10
                return number + 10;
            }
            else
            {
                // Handle the case where the string cannot be converted
                Console.WriteLine("Invalid input: String could not be converted to an integer.");
                return 0; // Or any other default value you prefer
            }
        }
    }
}
