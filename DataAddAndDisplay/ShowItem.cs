using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public class ShowItem
    {
        public void ShowProducts(List<Item> item)
        {
            Console.WriteLine("Available Products:" +
                            "\n\"===================\"");

            for (int i = 0; i < item.Count; i++)
            {
                Console.WriteLine($"{i + 1} - Name: {item[i].Name}, Stock {item[i].Stock}, Price: {item[i].Price}, Category: {item[i].ItemType}");
            }

            Console.WriteLine();
        }

    }

}
