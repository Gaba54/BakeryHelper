using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.DataAccess.Entities
{
    public class Order : EntityBase
    {
        public string DayOfTheWeek { get; set; } //or int 
        public List<Product> ProductsFromCustomers { get; set; } //jako lista produktow bedacych na rozpisce
        public List<Customers> Customers { get; set; }

    }
}
