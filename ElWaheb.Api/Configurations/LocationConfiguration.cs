using ElWaheb.Api.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElWaheb.Api.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Latitude).IsRequired();
            builder.Property(l => l.Longititude).IsRequired();
            builder.Property(l => l.State).IsRequired().HasMaxLength(50);
            builder.Property(l => l.City).IsRequired().HasMaxLength(50);

            //builder.HasMany(l => l.Users)
            //    .WithOne(u => u.Location)
            //    .HasForeignKey(u => u.LocationId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
