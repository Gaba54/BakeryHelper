using MediatR;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class DeleteProductRequest : IRequest<DeleteProductResponse>
    {
        public int Id { get; set; }
    }
}
