using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSDProject.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseDatabase",
                columns: new[] { "CourseDatabaseId", "LanguageName" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Burmese" },
                    { 3, "Malay" },
                    { 4, "Hindi" }
                });

            migrationBuilder.InsertData(
                table: "RewardShop",
                columns: new[] { "RewardShopId", "PointCost", "RewardType" },
                values: new object[,]
                {
                    { 1, "500 points", "Monitor" },
                    { 2, "450 points", "Microphone" },
                    { 3, "1000 points", "Laptop" },
                    { 4, "300 points", "PowerBank" },
                    { 5, "600 points", "AppleWatch" }
                });

            migrationBuilder.InsertData(
                table: "StoreItem",
                columns: new[] { "StoreItemId", "Answer", "CourseDatabaseId", "MultipleChoice", "Questions" },
                values: new object[,]
                {
                    { 1, 3, 4, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "How do you say 'How are you' in Hindi?" },
                    { 2, 1, 4, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "What does this sentence 'तुम किस विषय में रुचि रखते हो? ' mean?" },
                    { 3, 2, 4, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "What should you say infront of your parents when you greet them in a informal tone" },
                    { 4, 1, 4, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "'यह जगह कहाँ है?' means 'Where is this place?'. Is this true or false?" },
                    { 5, 3, 1, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "Which word is a noun?" },
                    { 6, 1, 1, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "Which word is an adjective?" },
                    { 7, 3, 1, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "Which sentence is grammatically correct?" },
                    { 8, 4, 1, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "Which sentence uses 'their' correctly?" },
                    { 9, 2, 3, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "What does the Malay word 'Selamat' mean?" },
                    { 10, 4, 3, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "What is the Malay word for 'Thank you'?" },
                    { 11, 4, 3, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "Which malay sentence is correct when speaking to elders?" },
                    { 12, 1, 3, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "Does this sentence 'Saya suka makan nasi lemak di waktu pag' mean ' I like to eat nasi lemak in the morning'?" },
                    { 13, 1, 2, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "What is the Burmese word for 'water'?" },
                    { 14, 2, 2, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "What does 'မင်္ဂလာပါ' mean?" },
                    { 15, 4, 2, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "Which word is a Burmese noun?" },
                    { 16, 3, 2, "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho", "What is the plural form of 'ပန်းသီး' (apple) in Burmese?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RewardShop",
                keyColumn: "RewardShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RewardShop",
                keyColumn: "RewardShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RewardShop",
                keyColumn: "RewardShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RewardShop",
                keyColumn: "RewardShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RewardShop",
                keyColumn: "RewardShopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StoreItem",
                keyColumn: "StoreItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CourseDatabase",
                keyColumn: "CourseDatabaseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseDatabase",
                keyColumn: "CourseDatabaseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseDatabase",
                keyColumn: "CourseDatabaseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseDatabase",
                keyColumn: "CourseDatabaseId",
                keyValue: 4);
        }
    }
}
