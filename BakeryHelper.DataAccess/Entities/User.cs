using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        private string Password { get; set; }



    }
}
