using AwesomeSocialMedia.Users.Core.Entities;

namespace AwesomeSocialMedia.Users.Application.Commands.UpdateUser;

public class LocationInfoModel
{
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    
    public LocationInfo ToValueObject()
    {
        return new LocationInfo(City, State, Country);
    }
}