using Point_of_sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.SingleResponsibility
{
    public class ItemProcessor : IteamHandler
    {
        private readonly IUserInputHandler userInputHandler;

        public ItemProcessor(IUserInputHandler userInputHandler)
        {
            this.userInputHandler = userInputHandler;
        }

        public void ProcessSelectedItem(List<Item> items, int selectedIndex, ref decimal total, IUserInputHandler userInputHandler)
        {
            Item selectedItem = items[selectedIndex - 1];

            Console.Write($"Enter the quantity for {selectedItem.Name}: ");

            while (true)
            {
                if (!userInputHandler.TryGetQuantity(out int quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please try again.");
                    return;
                }

                if (quantity > selectedItem.Stock)
                {
                    Console.WriteLine($"The entered quantity ({quantity}) exceeds the available stock ({selectedItem.Stock}). " +
                                      "Please enter a valid quantity.");
                }
                else
                {
                    selectedItem.Stock -= quantity;

                    decimal amount = selectedItem.CalculateAmount(quantity);
                    decimal taxes = selectedItem.CalculateTaxes();

                    total += amount + taxes;

                    DisplayItemDetails(selectedItem, quantity, amount, taxes);
                    Console.Write("Select another product number (0 to finish): ");
                    break;
                }
            }
        }

        private void DisplayItemDetails(Item selectedItem, int quantity, decimal amount, decimal taxes)
        {
            Console.WriteLine($"Added {quantity} {selectedItem.Name}, Amount: {amount}, Taxes: {taxes}");
        }

    }
}
