using Point_of_sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Adapter
{
    internal class ItemsAdapter : Items
    {
        
        private readonly Items _originalItem;

        public ItemsAdapter(Items originalItem)
        {
            _originalItem = originalItem;
        }

        public string Name => _originalItem.Name;

        public decimal Price => _originalItem.Price;

        public decimal CalculateAmount(int NumberOfItems)
        {
            return _originalItem.CalculateAmount(NumberOfItems);
        }

        public decimal CalculateTaxes()
        {
            return _originalItem.CalculateTaxes();
        }

    }
}
