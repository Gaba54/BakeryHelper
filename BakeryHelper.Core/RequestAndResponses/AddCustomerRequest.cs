using BakeryHelper.Core.Models;
using MediatR;
using System.Collections.Generic;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class AddCustomerRequest : IRequest<AddCustomerResponse>
    {
        public string Name { get; set; }
        public int NIP { get; set; }
        public List<Product> Products { get; set; }
    }
}
