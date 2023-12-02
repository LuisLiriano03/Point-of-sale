
using Point_of_sale.Adapter;
using Point_of_sale.DataAddAndDisplay;
using Point_of_sale.ItemsExceptions;
using Point_of_sale.Models;
using Point_of_sale.SingleResponsibility;

List<Item> item = new List<Item>();

ShowItem showItems = new ShowItem();
AddItem addItems = new AddItem();

IUserInputHandler userInputHandler = new ConsoleUserInputHandler();
ProductProcessor productProcessor = new ProductProcessor(userInputHandler);
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






























































//using Point_of_sale.Adapter;
//using Point_of_sale.Models;
//using Point_of_sale.ItemsExceptions;


//Console.WriteLine("Enter a options");
//int opcion = InputHelper.AskForNumber();


// Interfaz para la facturación





//Billing billing = new Billing();

//bool again = true;
//Items items = null;
//string NameItems;
//decimal PriceItems;

//while (again)
//{
//    Console.WriteLine("\nSelect the type of item:"
//                     + "\n1. Family Basket"
//                     + "\n2. Clothing"
//                     + "\n3. Technology"
//                     + "\n4. Exit application");

//    Console.Write("\nEnter a Options: ");
//    int opcion = InputHelper.AskForNumber();

//    switch (opcion)
//    {
//        case 1:
//            NameItems = "Rice";
//            PriceItems = 5.0m;
//            items = new BasketItems(NameItems, PriceItems);
//            break;
//        case 2:
//            NameItems = "Shirt";
//            PriceItems = 20.0m;
//            items = new ItemsDress(NameItems, PriceItems);
//            break;
//        case 3:
//            NameItems = "Smartphone";
//            PriceItems = 300.0m;
//            items = new TecnologyItems(NameItems, PriceItems);
//            break;
//        case 4:
//            Console.WriteLine("Exit application.");
//            return;
//        default:
//            Console.WriteLine("Invalid option, please select a valid option.");
//            break;
//    }

//    if (again)
//    {
//        Console.Write("Enter the Quantity of the items: ");
//        int NumberOfItems = InputHelper.AskForNumber();

//        ItemsAdapter itemsadapter = new ItemsAdapter(items);
//        decimal total = billing.ChargeItems(itemsadapter, NumberOfItems);

//        Console.WriteLine($"Total ({items.Name}): {total}");
//    }

//    if (again)
//    {
//        Console.WriteLine("\r\nDo you want to return to the menu? (S/N): ");
//        string answer = InputHelper.RequestTheText().Trim().ToUpper();

//        if(again = answer == "S"){
//            Console.WriteLine("Again application.\n");
//        } else {
//            Console.WriteLine("Exit application.\n");
//        }
//    }


//}


