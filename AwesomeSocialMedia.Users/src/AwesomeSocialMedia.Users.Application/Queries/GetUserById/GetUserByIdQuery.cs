using AwesomeSocialMedia.Users.Application.Models;
using MediatR;

namespace AwesomeSocialMedia.Users.Application.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<BaseResult<GetUserByIdViewModel>>
{
    public Guid Id { get; set; }
    
    public GetUserByIdQuery(Guid id)
    {
        Id = id;
    }
}