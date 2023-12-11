using Point_of_sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Adapter
{
    public class ItemAdapter : Item
    {
        private readonly Item item;

        public ItemAdapter(Item originalItem)
        {
            item = originalItem;
        }

        public string Name => item.Name;
        public decimal Price => item.Price;
        
        public string ItemType => item.ItemType;

        int Item.Stock { get => item.Stock; set => item.Stock = value; }

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
