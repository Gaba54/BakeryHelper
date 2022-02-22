using System;

namespace BakeryHelper.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        private string Password { get; set; }

    }
}
