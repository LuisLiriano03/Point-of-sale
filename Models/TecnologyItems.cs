using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public class TecnologyItems : Items
    {
        public string Name { get; }
        public decimal Price { get; }
        public string ItemType => "TecnologyItems";
        private decimal Taxes { get; } = 0.18m;
        private decimal ItemValue { get; } = 0.10m;
        
        public TecnologyItems(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public decimal CalculateAmount(int NumberOfItems)=> Price * NumberOfItems;

        public decimal CalculateTaxes() => Price * (Taxes + ItemValue);

    }
}
