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
    public class DeleteOrderHandler : IRequestHandler<DeleteOrderRequest, DeleteOrderResponse>
    {
        public Task<DeleteOrderResponse> Handle(DeleteOrderRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
