using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.SingleResponsibility
{
    public class ConsoleUserInputHandler : IUserInputHandler
    {
        public bool TryGetSelectedIndex(out int selectedIndex, int itemCount)
        {
            return int.TryParse(Console.ReadLine(), out selectedIndex) && selectedIndex >= 0 && selectedIndex <= itemCount;
        }

        public bool TryGetQuantity(out int quantity)
        {
            return int.TryParse(Console.ReadLine(), out quantity);
        }
    }
}
