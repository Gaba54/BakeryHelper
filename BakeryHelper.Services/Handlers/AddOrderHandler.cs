using BakeryHelper.Core.RequestAndResponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BakeryHelper.Services.Handlers
{
    public class AddOrderHandler : IRequestHandler<AddOrderRequest, AddOrderResponse>
    {
        public Task<AddOrderResponse> Handle(AddOrderRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
