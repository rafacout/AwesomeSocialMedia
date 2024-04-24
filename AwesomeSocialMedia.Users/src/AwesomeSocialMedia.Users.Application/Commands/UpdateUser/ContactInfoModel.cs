using AwesomeSocialMedia.Users.Core.Entities;

namespace AwesomeSocialMedia.Users.Application.Commands.UpdateUser;

public class ContactInfoModel
{
    public string Email { get; set; }
    public string WebSite { get; set; }
    public string PhoneNumber { get; set; }
    
    public ContactInfo ToValueObject()
    {
        return new ContactInfo(Email, WebSite, PhoneNumber);
    }
}