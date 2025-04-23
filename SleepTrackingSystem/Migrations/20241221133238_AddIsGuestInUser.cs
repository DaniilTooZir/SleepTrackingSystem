using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SleepTrackingSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddIsGuestInUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGuest",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGuest",
                table: "Users");
        }
    }
}
