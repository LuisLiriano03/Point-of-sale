using Point_of_sale.ItemsExceptions;
using Point_of_sale.Models;

namespace Point_of_sale.DataAddAndDisplay
{
    public class AddItems
    {
        public void AddProduct(List<Items> items)
        {
            Items items1;
            bool agian = true;

            Console.Write("\nEnter the item name: ");
            string name = InputHelper.RequestTheText();

            Console.Write("Enter the item price: ");
            decimal price = InputHelper.AskForDecimal();

            while (agian)
            {

                Console.Write("\nEnter the item type:" +
                        "\n1 - Family basket" +
                        "\n2 - Clothes" +
                        "\n3 - Technology\n");

                int option = InputHelper.AskForNumber();

                switch (option)
                {
                    case 1:
                        items1 = new BasketItems(name, price);
                        break;
                    case 2:
                        items1 = new ItemsDress(name, price);
                        break;
                    case 3:
                        items1 = new TecnologyItems(name, price);
                        break;
                    default:
                        Console.WriteLine("Invalid item type. Please try again.\n");
                        continue;
                }

                items.Add(items1);

                Console.WriteLine($"Item added successfully. Type: {option}\n");
                agian = false;

            }

        }

    }

}
