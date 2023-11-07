using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    internal class TecnologyItems : Items
    {
        public string Name { get; }
        public decimal Price { get; }

        public TecnologyItems(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public decimal CalculateAmount(int NumberOfItems)
        {
            return Price * NumberOfItems;
        }

        public decimal CalculateTaxes()
        {
            return Price * (0.18m + 0.10m);
        }

    }
}
