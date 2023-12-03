using Point_of_sale.ItemsExceptions;
using Point_of_sale.Models;

namespace Point_of_sale.DataAddAndDisplay
{
    public class AddItem
    {
        public void AddProduct(List<Item> item)
        {
            Item item1;
            bool LoopControl = true;

            Console.Write("\nEnter the item name: ");
            string name = InputHelper.RequestTheText();

            Console.Write("\nEnter the item price: ");
            decimal price = InputHelper.AskForDecimal();

            Console.Write("\nEnter the stock: ");
            int stock = InputHelper.AskForNumber();

            while (LoopControl)
            {

                Console.Write("\nEnter the item type:" +
                        "\n1 - Family basket" +
                        "\n2 - Clothes" +
                        "\n3 - Technology\n");

                int option = InputHelper.AskForNumber();

                switch (option)
                {
                    case 1:
                        item1 = new BasketItem(name, price, stock);
                        break;
                    case 2:
                        item1 = new ItemDress(name, price, stock);
                        break;
                    case 3:
                        item1 = new TecnologyItem(name, price, stock);
                        break;
                    default:
                        Console.WriteLine("Invalid item type. Please try again.\n");
                        continue;
                }

                item.Add(item1);

                Console.WriteLine($"Item added successfully. Type: {option}\n");
                LoopControl = false;
            }

        }

    }

}
