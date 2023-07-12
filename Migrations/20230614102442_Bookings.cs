using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class Bookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfBooking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfBooker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FixedPriceOfTicket = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    NumberOfTicketsPurchased = table.Column<int>(type: "int", nullable: false),
                    Booking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketPurchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ETicketPaymentAccountNumber = table.Column<int>(type: "int", nullable: false),
                    TicketPaymentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfFirstPayment = table.Column<int>(type: "int", nullable: false),
                    AmountOfSecondPayment = table.Column<int>(type: "int", nullable: false),
                    ReceivedDateOfFirstPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedDateOfSecondPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMonthlyExpenditure = table.Column<int>(type: "int", nullable: false),
                    TotalYearlyExpenditure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
