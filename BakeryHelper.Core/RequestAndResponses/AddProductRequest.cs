using MediatR;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class AddProductRequest : IRequest<AddProductResponse>
    {
        public string Name { get; set; }
        public int Weight { get; set; }

    }
}
