using BakeryHelper.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class AddOrderRequest : IRequest<AddOrderResponse>
    {
        public string DayOfTheWeek { get; set; } 
        public List<Product> ProductsFromCustomers { get; set; } 
        public List<Customer> Customers { get; set; }

    }
}
