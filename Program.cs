﻿
using Point_of_sale.Adapter;
using Point_of_sale.Models;
using Point_of_sale.ItemsExceptions;


Billing billing = new Billing();

bool again = true;
Items items = null;
string NameItems;
decimal PriceItems;

while (again)
{
    Console.WriteLine("\nSelect the type of item:"
                     + "\n1. Family Basket"
                     + "\n2. Clothing"
                     + "\n3. Technology"
                     + "\n4. Exit application");

    Console.Write("\nEnter a Options: ");
    int opcion = InputHelper.AskForNumber();

    switch (opcion)
    {
        case 1:
            NameItems = "Rice";
            PriceItems = 5.0m;
            items = new BasketItems(NameItems, PriceItems);
            break;
        case 2:
            NameItems = "Shirt";
            PriceItems = 20.0m;
            items = new ItemsDress(NameItems, PriceItems);
            break;
        case 3:
            NameItems = "Smartphone";
            PriceItems = 300.0m;
            items = new TecnologyItems(NameItems, PriceItems);
            break;
        case 4:
            Console.WriteLine("Exit application.");
            return;
        default:
            Console.WriteLine("Invalid option, please select a valid option.");
            break;
    }

    if (again)
    {
        Console.Write("Enter the Quantity of the items: ");
        int NumberOfItems = InputHelper.AskForNumber();

        ItemsAdapter itemsadapter = new ItemsAdapter(items);
        decimal total = billing.ChargeItems(itemsadapter, NumberOfItems);

        Console.WriteLine($"Total ({items.Name}): {total}");
    }
    
    if (again)
    {
        Console.WriteLine("\r\nDo you want to return to the menu? (S/N): ");
        string answer = InputHelper.RequestTheText().Trim().ToUpper();

        if(again = answer == "S"){
            Console.WriteLine("Again application.\n");
        } else {
            Console.WriteLine("Exit application.\n");
        }
    }
    

}


