using Point_of_sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Adapter
{
    internal class ItemsAdapter : Items
    {
        private readonly Items items;

        public ItemsAdapter(Items originalItem)
        {
            items = originalItem;
        }

        public string Name => items.Name;

        public decimal Price => items.Price;
        public string ItemType => items.ItemType;

        public decimal CalculateAmount(int NumberOfItems)
        {
            return items.CalculateAmount(NumberOfItems);
        }

        public decimal CalculateTaxes()
        {
            return items.CalculateTaxes();
        }

    }
}
