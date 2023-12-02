using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale.Models
{
    public interface IInvoicing
    {
        void GenerateInvoice(List<Item> item);
    }
}
