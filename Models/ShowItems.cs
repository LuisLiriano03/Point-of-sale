using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public class ShowItems
    {
        public void ShowProducts(List<Items> items)
        {
            Console.WriteLine("Available Products:");
            Console.WriteLine("===================");

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - Name: {items[i].Name}, Price: {items[i].Price}");
            }

            Console.WriteLine();
        }

    }
}
