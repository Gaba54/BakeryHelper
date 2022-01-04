using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.DataAccess.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NIP { get; set; }
        public List<Products> Products { get; set; }
        //public string City { get; set; }
        //public int ZipCode { get; set; } //trzeba dodac maskowanie podczas wprowadzania danych
        //public string StreetName { get; set; }
        //public int HouseNumber { get; set; }
    }
}
