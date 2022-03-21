using MediatR;


namespace BakeryHelper.Core.RequestAndResponses
{
    public class AddUserRequest : IRequest<AddUserResponse>
    {
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
