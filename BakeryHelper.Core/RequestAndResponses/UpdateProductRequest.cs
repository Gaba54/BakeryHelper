using MediatR;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class UpdateProductRequest : IRequest<UpdateProductResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
    }
}
