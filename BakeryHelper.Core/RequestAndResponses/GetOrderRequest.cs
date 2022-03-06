using MediatR;
namespace BakeryHelper.Core.RequestAndResponses
{
    public class GetOrderRequest : IRequest<GetOrderResponse>
    {
        public int Id { get; set; }

    }
}
