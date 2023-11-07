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
        private readonly Items _items;

        public ItemsAdapter(Items items)
        {
            _items = items;
        }

        public string Name => _items.Name;

        public decimal Price => _items.Price;

        public decimal CalculateAmount(int NumberOfItems)
        {
            return _items.CalculateAmount(NumberOfItems);
        }

        public decimal CalculateTaxes()
        {
            switch (_items)
            {
                case ItemsDress _:
                    return _items.CalculateAmount(1) * 0.18m;
                case TecnologyItems _:
                    return _items.CalculateAmount(1) * (0.18m + 0.10m);
                default:
                    return 0; 
            }
        }

    }
}
