
using Point_of_sale.Adapter;
using Point_of_sale.DataAddAndDisplay;
using Point_of_sale.ItemsExceptions;
using Point_of_sale.Models;
using Point_of_sale.SingleResponsibility;

List<Item> item = new List<Item>();

ShowItem showItems = new ShowItem();
AddItem addItems = new AddItem();

IUserInputHandler userInputHandler = new ConsoleUserInputHandler();
ItemProcessor productProcessor = new ItemProcessor(userInputHandler);
Billing invoicing = new Billing(showItems, productProcessor, userInputHandler);

while (true)
{
    Console.WriteLine("Select an option:" +
        "\n1 - Add Product" +
        "\n2 - View Products" +
        "\n3 - Generate Invoice" +
        "\n4 - Exit");

    Console.Write("\nEnter a Options: ");
    int option = InputHelper.AskForNumber();

    switch (option)
    {
        case 1:
            addItems.AddProduct(item);
            break;
        case 2:
            showItems.ShowProducts(item);
            break;
        case 3:
            List<Item> adaptedItems = new List<Item>();

            foreach (var item1 in item)
            {
                adaptedItems.Add(new ItemsAdapter(item1));
            }

            invoicing.GenerateInvoice(adaptedItems);
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine();
}





