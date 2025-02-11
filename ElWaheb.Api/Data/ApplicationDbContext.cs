using ElWaheb.Api.Entites;
using Microsoft.EntityFrameworkCore;

namespace ElWaheb.Api.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        DbSet<User> Users { get; set; }
        DbSet<Notification> Notifications { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<DonationRequest> DonationRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }


    }
}
