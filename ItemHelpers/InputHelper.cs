using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.ItemsExceptions
{
    public static class InputHelper
    {
        public static int AskForNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int numero) && numero != 0)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Invalid value, please enter a valid non-zero number.");
                }
            }
        }

        public static decimal AskForDecimal()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid value, please enter a valid decimal number.");
                }
            }
        }

        public static string RequestTheText()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (IsTextValid(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid value, please enter a valid text.");
                }
            }
        }

        private static bool IsTextValid(string input)
        {
            return !System.Text.RegularExpressions.Regex.IsMatch(input, @"\d");
        }

    }
}
