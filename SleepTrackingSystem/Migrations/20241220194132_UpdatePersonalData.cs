using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SleepTrackingSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PersonalData",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_UserId",
                table: "PersonalData",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_Users_UserId",
                table: "PersonalData",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_Users_UserId",
                table: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_UserId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PersonalData");
        }
    }
}
