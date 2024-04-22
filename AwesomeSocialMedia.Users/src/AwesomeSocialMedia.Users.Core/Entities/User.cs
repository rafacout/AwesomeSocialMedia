using AwesomeSocialMedia.Users.Core.Enums;
using AwesomeSocialMedia.Users.Core.Events;

namespace AwesomeSocialMedia.Users.Core.Entities;

public class User : AggregateRoot
{
    public User(string fullName, string displayName, DateTime birthDate, string email)
    : base()
    {
        FullName = fullName;
        DisplayName = displayName;
        BirthDate = birthDate;
        Email = email;
        Status = UserStatus.Active;
        
        Events.Add(new UserCreated(Email, DisplayName));
    }

    public string FullName { get; private set; }
    public string DisplayName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Email { get; private set; }
    
    public string? Header { get; private set; }
    public string? Bio { get; private set; }
    public string? ProfilePicture { get; private set; }
    
    public UserStatus Status { get; private set; }
    
    //Value Objects
    public LocationInfo? Location { get; private set; }
    public ContactInfo? Contact { get; private set; }
    
    public void Update(string displayName, 
        string header, 
        string bio, 
        string profilePicture,
        LocationInfo location,
        ContactInfo contact)
    {
        DisplayName = displayName;
        Header = header;
        Bio = bio;
        ProfilePicture = profilePicture;
        Location = location;
        Contact = contact;
    }
}