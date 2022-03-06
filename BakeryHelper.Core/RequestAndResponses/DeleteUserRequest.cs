using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryHelper.Core.RequestAndResponses
{
    public class DeleteUserRequest : IRequest<DeleteUserResponse>
    {
        public int Id { get; set; }
    }
}
