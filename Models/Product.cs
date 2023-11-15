using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public class Product : Items
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateAmount(int NumberOfItems)
        {
            return Price;
        }
        public decimal CalculateTaxes()
        {
            return Price;
        }
    }
}
