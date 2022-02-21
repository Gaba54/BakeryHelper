using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.DataAccess.Entities
{
    public class Products : EntityBase
    {
        public string Name { get; set; }        
        public int Weight { get; set; }
    }
}
