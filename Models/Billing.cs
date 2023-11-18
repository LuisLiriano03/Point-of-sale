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
        private readonly ShowItems showItems;
        private readonly IUserInputHandler userInputHandler;
        private readonly IProductProcessor productProcessor;

        public Billing(ShowItems showItems, IProductProcessor productProcessor, IUserInputHandler userInputHandler)
        {
            this.showItems = showItems;
            this.productProcessor = productProcessor;
            this.userInputHandler = userInputHandler;
        }

        public void GenerateInvoice(List<Items> items)
        {
            Console.WriteLine("Generated Invoice:" +
                            "\n\"===================\"");

            decimal total = 0;

            showItems.ShowProducts(items);

            Console.Write("Select the product number to add to the invoice (0 to finish): ");

            while (true)
            {
                if (!userInputHandler.TryGetSelectedIndex(out int selectedIndex, items.Count) || selectedIndex == 0)
                {
                    break;
                }

                productProcessor.ProcessSelectedProduct(items, selectedIndex, ref total, userInputHandler);
            }

            Console.WriteLine($"Total: {total}");
        }
    }
}
