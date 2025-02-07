using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialTableSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseDatabase",
                columns: table => new
                {
                    CourseDatabaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDatabase", x => x.CourseDatabaseId);
                });

            migrationBuilder.CreateTable(
                name: "RewardShop",
                columns: table => new
                {
                    RewardShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointCost = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardShop", x => x.RewardShopId);
                });

            migrationBuilder.CreateTable(
                name: "StoreItem",
                columns: table => new
                {
                    StoreItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleChoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<int>(type: "int", nullable: true),
                    CourseDatabaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreItem", x => x.StoreItemId);
                    table.ForeignKey(
                        name: "FK_StoreItem_CourseDatabase_CourseDatabaseId",
                        column: x => x.CourseDatabaseId,
                        principalTable: "CourseDatabase",
                        principalColumn: "CourseDatabaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoursePrice = table.Column<float>(type: "real", nullable: true),
                    CourseDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAccId = table.Column<int>(type: "int", nullable: true),
                    CourseDatabaseId = table.Column<int>(type: "int", nullable: false),
                    ScoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Course_CourseDatabase_CourseDatabaseId",
                        column: x => x.CourseDatabaseId,
                        principalTable: "CourseDatabase",
                        principalColumn: "CourseDatabaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentPoints = table.Column<int>(type: "int", nullable: true),
                    RewardId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_UserProfile_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProfile_RewardShop_RewardId",
                        column: x => x.RewardId,
                        principalTable: "RewardShop",
                        principalColumn: "RewardShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointsAwarded = table.Column<int>(type: "int", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    StoreItemId = table.Column<int>(type: "int", nullable: true),
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreId);
                    table.ForeignKey(
                        name: "FK_Score_StoreItem_StoreItemId",
                        column: x => x.StoreItemId,
                        principalTable: "StoreItem",
                        principalColumn: "StoreItemId");
                    table.ForeignKey(
                        name: "FK_Score_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAcc",
                columns: table => new
                {
                    UserAccId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAcc", x => x.UserAccId);
                    table.ForeignKey(
                        name: "FK_UserAcc_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseDatabaseId",
                table: "Course",
                column: "CourseDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ScoreId",
                table: "Course",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_UserAccId",
                table: "Course",
                column: "UserAccId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_StoreItemId",
                table: "Score",
                column: "StoreItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_UserProfileId",
                table: "Score",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreItem_CourseDatabaseId",
                table: "StoreItem",
                column: "CourseDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAcc_UserProfileId",
                table: "UserAcc",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_CourseId",
                table: "UserProfile",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_RewardId",
                table: "UserProfile",
                column: "RewardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Score_ScoreId",
                table: "Course",
                column: "ScoreId",
                principalTable: "Score",
                principalColumn: "ScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_UserAcc_UserAccId",
                table: "Course",
                column: "UserAccId",
                principalTable: "UserAcc",
                principalColumn: "UserAccId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseDatabase_CourseDatabaseId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreItem_CourseDatabase_CourseDatabaseId",
                table: "StoreItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Score_ScoreId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_UserAcc_UserAccId",
                table: "Course");

            migrationBuilder.DropTable(
                name: "CourseDatabase");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "StoreItem");

            migrationBuilder.DropTable(
                name: "UserAcc");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "RewardShop");
        }
    }
}
