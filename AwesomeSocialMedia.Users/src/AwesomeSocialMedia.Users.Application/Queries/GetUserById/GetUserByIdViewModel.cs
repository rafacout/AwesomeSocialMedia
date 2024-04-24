using AwesomeSocialMedia.Users.Core.Entities;

namespace AwesomeSocialMedia.Users.Application.Queries.GetUserById;

public class GetUserByIdViewModel
{
    public GetUserByIdViewModel(User user)
    {
        DisplayName = user.DisplayName;
        BirthDate = user.BirthDate;
        Header = user.Header;
        Bio = user.Bio;
        Email = user.Email;
        Cowntry = user.Location?.Country;
        WebSite = user.Contact?.WebSite;
    }

    public string DisplayName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string? Header { get; private set; }
    public string? Bio { get; private set; } 
    public string Email { get; private set; }
    public string? Cowntry { get; private set; }
    public string? WebSite { get; set; }
}