using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public interface Item
    {
        public string Name { get; }
        public decimal Price { get;  }
        public int Stock { get; set; }
        string ItemType { get; }
        decimal CalculateAmount(int NumberOfItems);
        decimal CalculateTaxes();
    }
}
