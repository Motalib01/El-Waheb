using ElWaheb.Api.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElWaheb.Api.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u=>u.FullName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.BirthDate).IsRequired();
            builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);            
            //builder.Property(u => u.LocationId).HasMaxLength(50);

            builder.HasMany(u => u.DonationRequests)
                .WithOne(dr => dr.User)
                .HasForeignKey(dr => dr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
