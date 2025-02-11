using ElWaheb.Api.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElWaheb.Api.Configurations
{
    public class DonationRequestConfiguration : IEntityTypeConfiguration<DonationRequest>
    {
        public void Configure(EntityTypeBuilder<DonationRequest> builder)
        {
            builder.HasKey(dr => dr.Id);
            builder.Property(dr => dr.BloodType).IsRequired().HasMaxLength(50);
            builder.Property(dr => dr.NeededDate).IsRequired().HasMaxLength(50);
            builder.Property(dr => dr.Status).IsRequired().HasMaxLength(50);
            builder.Property(dr => dr.UserId).IsRequired();

            builder.HasOne(dr => dr.User)
                .WithMany(u => u.DonationRequests)
                .HasForeignKey(dr => dr.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
