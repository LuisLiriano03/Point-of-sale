using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public class BasketItem : Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public string ItemType => "BasketItems";

        public BasketItem(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public decimal CalculateAmount(int NumberOfItems) => Price * NumberOfItems;

        public decimal CalculateTaxes() => 0;
    }

}
