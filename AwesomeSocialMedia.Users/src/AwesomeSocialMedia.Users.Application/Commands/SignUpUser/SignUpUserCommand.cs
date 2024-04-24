using AwesomeSocialMedia.Users.Application.Models;
using AwesomeSocialMedia.Users.Core.Entities;
using MediatR;

namespace AwesomeSocialMedia.Users.Application.Commands.SignupUser;

public class SignUpUserCommand : IRequest<BaseResult<Guid>>
{
    public string FullName { get; set; }
    public string DisplayName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    
    // create a method ToEntity
    public User ToEntity()
    {
        return new User(FullName, DisplayName, BirthDate, Email);
    }
}