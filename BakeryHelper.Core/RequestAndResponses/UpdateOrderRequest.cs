using BakeryHelper.Core.Models;
using MediatR;
using System.Collections.Generic;


namespace BakeryHelper.Core.RequestAndResponses
{
    public class UpdateOrderRequest : IRequest<UpdateOrderResponse>
    { 
        public int Id { get; set; }
        public string DayOfTheWeek { get; set; }
        public List<Product> ProductsFromCustomers { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
