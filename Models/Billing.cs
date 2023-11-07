using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    internal class Billing
    {
        public decimal ChargeItems(Items items, int NumberOfItems)
        {
            decimal amount = items.CalculateAmount(NumberOfItems);
            decimal taxes = items.CalculateTaxes();
            decimal total = amount + taxes;
            return total;
        }

    }
}
