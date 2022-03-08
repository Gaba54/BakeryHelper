using System;
using System.Threading;
using System.Threading.Tasks;
using BakeryHelper.Core.RequestAndResponses;
using MediatR;

namespace BakeryHelper.Services.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductRequest, AddProductResponse>
    {
        public Task<AddProductResponse> Handle(AddProductRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
