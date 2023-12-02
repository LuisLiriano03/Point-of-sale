using Point_of_sale.Adapter;
using Point_of_sale.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public class Billing : IInvoicing
    {
        private readonly ShowItem showItems;
        private readonly IUserInputHandler userInputHandler;
        private readonly IteamHandler iteamHandler;

        public Billing(ShowItem showItems, IteamHandler iteamHandler, IUserInputHandler userInputHandler)
        {
            this.showItems = showItems;
            this.iteamHandler = iteamHandler;
            this.userInputHandler = userInputHandler;
        }

        public void GenerateInvoice(List<Item> item)
        {
            Console.WriteLine("Generated Invoice:" +
                            "\n\"===================\"");

            decimal total = 0;

            showItems.ShowProducts(item);

            Console.Write("Select the product number to add to the invoice (0 to finish): ");

            while (true)
            {
                if (!userInputHandler.TryGetSelectedIndex(out int selectedIndex, item.Count) || selectedIndex == 0)
                {
                    break;
                }

                iteamHandler.ProcessSelectedItem(item, selectedIndex, ref total, userInputHandler);
            }

            Console.WriteLine($"Total: {total}");
        }
    }
}
