using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.DataAccess.Entities
{
    public class Order : EntityBase
    {
        public string DayName { get; set; } 
        public List<Product> Products { get; set; } 
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
