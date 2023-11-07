using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    internal interface Items
    {
        string Name { get; }
        decimal Price { get; }
        decimal CalculateAmount(int NumberOfItems);
        decimal CalculateTaxes();

    }
}
