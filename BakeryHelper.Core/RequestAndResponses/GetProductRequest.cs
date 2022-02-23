using MediatR;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class GetProductRequest : IRequest<GetProductResponse>
    {
        public int Id { get; set; }
    }
}
