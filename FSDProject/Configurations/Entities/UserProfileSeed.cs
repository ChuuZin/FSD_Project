using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Configurations.Entities
{
    public class UserProfileSeed : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasData(
    new UserProfile
    {
        UserProfileId = 1,
        Status = "50%", // 50% progress
        CurrentPoints = 50, // No points earned
        CourseId = 1, 
        RewardId = 1 
    },
    new UserProfile
    {
        UserProfileId = 2,
        Status = "80%", // 80% progress in the course
        CurrentPoints = 100, // Earned 100 points
        CourseId = 1,
        RewardId = 1 
    }
);
        }
    }
}
