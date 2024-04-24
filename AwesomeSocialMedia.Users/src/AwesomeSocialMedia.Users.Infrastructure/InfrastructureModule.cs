using AwesomeSocialMedia.Users.Core.Repositories;
using AwesomeSocialMedia.Users.Infrastructure.Persistence;
using AwesomeSocialMedia.Users.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeSocialMedia.Users.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddDb("")
                .AddRepositories();
        }

        private static IServiceCollection AddDb(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<UsersDbContext>();
            
            return services;
        }
        
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            
            return services;
        }
    }
}
