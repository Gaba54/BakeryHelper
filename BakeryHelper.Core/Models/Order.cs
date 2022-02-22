using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.Core.Models
{
    public class Order
    {

        public int Id { get; set; }
        public string DayOfTheWeek { get; set; } 
        public List<Products> ProductsFromCustomers { get; set; }
        public List<Customers> Customers { get; set; }

    }
}
