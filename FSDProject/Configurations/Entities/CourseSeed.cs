using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Configurations.Entities
{
    public class CourseSeed : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder) => builder.HasData(
                // Seeding courses linked to the CourseDatabase
                new Course
                {
                    CourseId = 1,
                    CourseName = "English for Beginners",
                    CoursePrice = 10.5f, // Price in float
                    CourseDuration = "60 minutes", // Duration in minutes
                    CourseDatabaseId = 1 // Linked to English in CourseDatabase
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Advanced English",
                    CoursePrice = 15.0f,
                    CourseDuration = "90 minutes",
                    CourseDatabaseId = 1
                },
                new Course
                {
                    CourseId = 3,
                    CourseName = "Burmese Basics",
                    CoursePrice = 8.0f,
                    CourseDuration = "50 minutes",
                    CourseDatabaseId = 2 // Linked to Burmese in CourseDatabase
                },
                new Course
                {
                    CourseId = 4,
                    CourseName = "Conversational Burmese",
                    CoursePrice = 12.0f,
                    CourseDuration = "75 minutes",
                    CourseDatabaseId = 2
                },
                new Course
                {
                    CourseId = 5,
                    CourseName = "Malay Language Essentials",
                    CoursePrice = 9.5f,
                    CourseDuration = "55 minutes",
                    CourseDatabaseId = 3 // Linked to Malay in CourseDatabase
                },
                new Course
                {
                    CourseId = 6,
                    CourseName = "Hindi for Travelers",
                    CoursePrice = 11.0f,
                    CourseDuration = "65 minutes",
                    CourseDatabaseId = 4 // Linked to Hindi in CourseDatabase
                }
            );
    }
}
