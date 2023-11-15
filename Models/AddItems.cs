using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    internal class AddItems
    {
        public void AddProduct(List<Items> items)
        {
            Console.Write("Enter the item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the item price: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Items item = new Product { Name = name, Price = price };
                items.Add(item);

                Console.WriteLine("Item added successfully.\n");
            }
            else
            {
                Console.WriteLine("Invalid price. Please try again.\n");
            }
        }
    }
}
