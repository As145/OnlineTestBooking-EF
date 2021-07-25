using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTestBooking_EF.Migrations
{
    public partial class taaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Booking_BookingID",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_BookingID",
                table: "Result");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Result_BookingID",
                table: "Result",
                column: "BookingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Booking_BookingID",
                table: "Result",
                column: "BookingID",
                principalTable: "Booking",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
