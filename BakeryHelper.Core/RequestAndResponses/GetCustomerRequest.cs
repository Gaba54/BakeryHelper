using MediatR;


namespace BakeryHelper.Core.RequestAndResponses
{
    public class GetCustomerRequest : IRequest<GetCustomerResponse>
    {
        public int Id { get; set; }
    }
}
