using AwesomeSocialMedia.Users.Core.Entities;
using AwesomeSocialMedia.Users.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AwesomeSocialMedia.Users.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UsersDbContext _usersDbContext;
    
    public UserRepository(UsersDbContext usersDbContext)
    {
        _usersDbContext = usersDbContext;
    }

    public async Task AddAsync(User user)
    {
        await _usersDbContext.Users.AddAsync(user);

        await _usersDbContext.SaveChangesAsync();
    }

    public Task UpdateAsync(User user)
    {
        _usersDbContext.Update(user);

        return _usersDbContext.SaveChangesAsync();
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        var user = await _usersDbContext.Users.SingleOrDefaultAsync(x => x.Id == id);

        return user;
    }
}