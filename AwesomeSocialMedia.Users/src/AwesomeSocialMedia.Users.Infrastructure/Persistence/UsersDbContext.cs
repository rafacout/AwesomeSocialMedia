using AwesomeSocialMedia.Users.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AwesomeSocialMedia.Users.Infrastructure.Persistence
{
    public class UsersDbContext : DbContext 
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(user => user.Id);

                entity.OwnsOne(e => e.Location, builder =>
                {
                    builder.Property(li => li.City).HasColumnName("City").IsRequired(false);
                    builder.Property(li => li.Country).HasColumnName("Country").IsRequired(false);
                    builder.Property(li => li.State).HasColumnName("State").IsRequired(false);
                });

                entity.OwnsOne(user => user.Contact, builder =>
                {
                    builder.Property(ci => ci.Email).HasColumnName("Email").IsRequired(false);
                    builder.Property(ci => ci.WebSite).HasColumnName("WebSite").IsRequired(false);
                    builder.Property(ci => ci.PhoneNumber).HasColumnName("PhoneNumber").IsRequired(false);
                });
                
                entity.Ignore(user => user.Events);
            });
        }

    }
}
