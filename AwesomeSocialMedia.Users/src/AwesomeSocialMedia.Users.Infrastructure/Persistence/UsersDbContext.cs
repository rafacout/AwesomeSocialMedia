using AwesomeSocialMedia.Users.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AwesomeSocialMedia.Users.Infrastructure.Persistence
{
    public class UsersDbContext {
        public List<User> Users { get; set; }

        public UsersDbContext()
        {
            Users = new List<User>();
        }
    }
}
