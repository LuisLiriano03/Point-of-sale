using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.SingleResponsibility
{
    public interface IUserInputHandler
    {
        bool TryGetSelectedIndex(out int selectedIndex, int itemCount);
        bool TryGetQuantity(out int quantity);

    }
}
