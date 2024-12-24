using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class TaskItemDatabaseInitialization : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.HasData(
                [
                    new TaskItem
                    {
                        Id = 1,
                        Title = "Finish the Blazor tutortial",
                        Description = "Finish the Blazor tutortial with Clean Architecture and then deploy the project to GitHub",
                        IsCompleted = false,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new TaskItem
                    {
                        Id = 2,
                        Title = "Clean up e-mail inbox",
                        Description = "Get rid of unnecessary mails in private e-mail inbox",
                        IsCompleted = false,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    }
                ]);

            builder.Property(q => q.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(q => q.Description)
                .IsRequired();
            builder.Property(q => q.IsCompleted)
                .IsRequired();

            builder.Property(q => q.Id)
                .IsRequired()
                .UseIdentityColumn();
            builder.Property(q => q.CreatedDate)
                .IsRequired();
            builder.Property(q => q.UpdatedDate)
                .IsRequired();
            builder.Property(q => q.CreatedBy);
            builder.Property(q => q.UpdatedBy);
        }
    }
}
