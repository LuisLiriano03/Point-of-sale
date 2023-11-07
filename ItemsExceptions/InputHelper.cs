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

                if (int.TryParse(input, out int numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Valor no válido, por favor ingrese un número.");
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
                    Console.WriteLine("Valor no válido, por favor ingrese un texto.");
                }
            }
        }

        private static bool IsTextValid(string input)
        {
            return !System.Text.RegularExpressions.Regex.IsMatch(input, @"\d");
        }

    }
}
