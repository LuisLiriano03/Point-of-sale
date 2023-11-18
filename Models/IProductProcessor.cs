using Point_of_sale.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public interface IProductProcessor
    {
        void ProcessSelectedProduct(List<Items> items, int selectedIndex, ref decimal total, IUserInputHandler userInputHandler);
    }
}
