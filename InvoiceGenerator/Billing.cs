using Point_of_sale.Models;
using Point_of_sale.SingleResponsibility;

namespace Point_of_sale.InvoiceGenerator
{
    public class Billing : IInvoicing
    {
        private readonly ShowItem showItems;
        private readonly IUserInputHandler userInputHandler;
        private readonly ItemHandler iteamHandler;

        public Billing(ShowItem showItems, ItemHandler iteamHandler, IUserInputHandler userInputHandler)
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
