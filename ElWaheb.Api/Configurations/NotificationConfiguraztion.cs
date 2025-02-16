using ElWaheb.Api.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElWaheb.Api.Configurations
{
    public class NotificationConfiguraztion : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Title).IsRequired().HasMaxLength(50);
            builder.Property(n => n.Body).IsRequired().HasMaxLength(250);
            builder.Property(n => n.SentAt).IsRequired();
            builder.Property(n => n.IsRead).IsRequired();


            builder.HasOne(n => n.User)
               .WithMany(u => u.Notifications)
               .HasForeignKey(n => n.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
