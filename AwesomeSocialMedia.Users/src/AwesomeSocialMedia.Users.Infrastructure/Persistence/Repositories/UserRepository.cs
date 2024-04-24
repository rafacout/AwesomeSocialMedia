using AwesomeSocialMedia.Users.Core.Entities;
using AwesomeSocialMedia.Users.Core.Repositories;

namespace AwesomeSocialMedia.Users.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UsersDbContext _usersDbContext;
    
    public UserRepository(UsersDbContext usersDbContext)
    {
        _usersDbContext = usersDbContext;
    }

    public Task AddAsync(User user)
    {
        _usersDbContext.Users.Add(user);

        return Task.CompletedTask;
    }

    public Task UpdateAsync(User user)
    {
        return Task.CompletedTask;
    }

    public Task<User> GetByIdAsync(Guid id)
    {
        var user = _usersDbContext.Users.SingleOrDefault(x => x.Id == id);

        return Task.FromResult(user);
    }
}