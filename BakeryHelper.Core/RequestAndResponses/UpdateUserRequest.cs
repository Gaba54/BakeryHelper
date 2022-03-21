using MediatR;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class UpdateUserRequest : IRequest<UpdateUserResponse>
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
