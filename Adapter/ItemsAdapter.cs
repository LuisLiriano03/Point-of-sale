using Point_of_sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Adapter
{
    public class ItemsAdapter : Item
    {
        private readonly Item item;

        public ItemsAdapter(Item originalItem)
        {
            item = originalItem;
        }

        public string Name => item.Name;

        public decimal Price => item.Price;
        public string ItemType => item.ItemType;

        public decimal CalculateAmount(int NumberOfItems)
        {
            return item.CalculateAmount(NumberOfItems);
        }

        public decimal CalculateTaxes()
        {
            return item.CalculateTaxes();
        }

    }
}
