using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.Core.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NIP { get; set; }
        public List<Product> Products { get; set; }


    }
}
