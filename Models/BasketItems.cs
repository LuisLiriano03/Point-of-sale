using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    internal class BasketItems : Items
    {
        public string Name { get; }
        public decimal Price { get; }

        public BasketItems(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public decimal CalculateAmount(int NumberOfItems)
        {
            return this.Price * NumberOfItems;
        }

        public decimal CalculateTaxes()
        {
            return 0; 
        }

    }
}
