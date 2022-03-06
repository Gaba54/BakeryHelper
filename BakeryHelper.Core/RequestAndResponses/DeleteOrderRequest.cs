using MediatR;


namespace BakeryHelper.Core.RequestAndResponses
{
    public class DeleteOrderRequest : IRequest<DeleteOrderResponse>
    {
        public int Id { get; set; }
    }
}
