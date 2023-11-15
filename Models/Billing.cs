using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public class Billing : IInvoicing
    {
        public void GenerateInvoice(List<Items> items)
        {
            ShowItems showItems = new ShowItems();
            Console.WriteLine("Generated Invoice:");
            Console.WriteLine("===================");

            decimal total = 0;

            showItems.ShowProducts(items);

            Console.Write("Select the product number to add to the invoice (0 to finish): ");

            while (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 0 && selectedIndex <= items.Count)
            {
                if (selectedIndex == 0)
                {
                    break;
                }

                Items selectedItem = items[selectedIndex - 1];

                Console.Write($"Enter the quantity for {selectedItem.Name}: ");
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                {
                    decimal amount = selectedItem.Price * quantity;
                    total += amount;

                    Console.WriteLine($"Added {quantity} {selectedItem.Name}(s) to the invoice. Amount: {amount}");
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please try again.");
                }

                Console.Write("Select another product number (0 to finish): ");
            }

            Console.WriteLine($"Total: {total}");



        }
    }
}
