using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTestBooking_EF.Migrations
{
    public partial class testtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdharNumber",
                table: "Registration");

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Registration");

            migrationBuilder.AddColumn<int>(
                name: "AdharNumber",
                table: "Registration",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
