using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.DataAccess.Entities
{
    public class Customer : EntityBase
    {    
        public string Name { get; set; }
        public int NIP { get; set; }
        public List<Product> Products { get; set; }
    }
}
