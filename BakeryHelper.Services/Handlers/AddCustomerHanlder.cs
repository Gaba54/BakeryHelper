using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BakeryHelper.Core.RequestAndResponses;
using MediatR;

namespace BakeryHelper.Services.Handlers
{
    public class AddCustomerHanlder : IRequestHandler<AddCustomerRequest, AddCustomerResponse>
    {
        public Task<AddCustomerResponse> Handle(AddCustomerRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
