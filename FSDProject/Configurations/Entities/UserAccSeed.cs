using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Configurations.Entities
{
    public class UserAccSeed : IEntityTypeConfiguration<UserAcc>
    {
        public void Configure(EntityTypeBuilder<UserAcc> builder)
        {
            builder.HasData(
    new UserAcc
    {
        UserAccId = 1,
        Username = "admin",
        Email = "admin@example.com", // Placeholder email
        Password = "hashed_password_here", // Hashed password
        UserProfileId = 1
    },
    new UserAcc
    {
        UserAccId = 2,
        Username = "test_user",
        Email = "test.user@example.com", // Placeholder email
        Password = "hashed_password_here", // Hashed password
        UserProfileId = 2
    }
);

        }
    }
}
