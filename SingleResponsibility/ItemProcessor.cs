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

        public void ProcessSelectedItem(List<Item> item, int selectedIndex, ref decimal total, IUserInputHandler userInputHandler)
        {
            Item selectedItem = item[selectedIndex - 1];
            Console.Write($"Enter the quantity for {selectedItem.Name}: ");

            if (!userInputHandler.TryGetQuantity(out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please try again.");
                return;
            }

            decimal amount = selectedItem.CalculateAmount(quantity);
            decimal taxes = selectedItem.CalculateTaxes();

            total += amount + taxes;

            DisplayItemDetails(selectedItem, quantity, amount, taxes);
            Console.Write("Select another product number (0 to finish): ");

        }

        private void DisplayItemDetails(Item selectedItem, int quantity, decimal amount, decimal taxes)
        {
            Console.WriteLine($"Added {quantity} {selectedItem.Name}, Amount: {amount}, Taxes: {taxes}");
        }

    }

}
