using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSDProject.Migrations
{
    /// <inheritdoc />
    public partial class UserProfileChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_RewardShop_RewardId",
                table: "UserProfile");

            migrationBuilder.AlterColumn<int>(
                name: "RewardId",
                table: "UserProfile",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "UserProfile",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_RewardShop_RewardId",
                table: "UserProfile",
                column: "RewardId",
                principalTable: "RewardShop",
                principalColumn: "RewardShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_RewardShop_RewardId",
                table: "UserProfile");

            migrationBuilder.AlterColumn<int>(
                name: "RewardId",
                table: "UserProfile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "UserProfile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_RewardShop_RewardId",
                table: "UserProfile",
                column: "RewardId",
                principalTable: "RewardShop",
                principalColumn: "RewardShopId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
