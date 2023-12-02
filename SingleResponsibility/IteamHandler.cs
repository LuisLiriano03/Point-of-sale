using Point_of_sale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.SingleResponsibility
{
    public interface IteamHandler
    {
        void ProcessSelectedItem(List<Item> items, int selectedIndex, ref decimal total, IUserInputHandler userInputHandler);
    }

}
