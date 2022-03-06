using MediatR;


namespace BakeryHelper.Core.RequestAndResponses
{
    public class DeleteCustomerRequest : IRequest<DeleteCustomerResponse>
    {
        public int Id { get; set; }
    }
}
