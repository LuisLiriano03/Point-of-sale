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
        public int Stock { get; set;}
        public string ItemType => "BasketItems";


        public BasketItem(string name, decimal price, int stock)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        public decimal CalculateAmount(int NumberOfItems) => Price * NumberOfItems;

        public decimal CalculateTaxes() => 0;

        
    }

}
