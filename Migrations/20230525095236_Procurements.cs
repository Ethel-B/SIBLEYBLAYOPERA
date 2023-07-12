using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class Procurements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_staffLog2",
                table: "staffLog2");

            migrationBuilder.RenameTable(
                name: "staffLog2",
                newName: "StaffLog2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffLog2",
                table: "StaffLog2",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Procurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomesticQuantity = table.Column<int>(type: "int", nullable: false),
                    FixedPrice = table.Column<int>(type: "int", nullable: false),
                    ProcurementCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyPlacementOrderQuantity = table.Column<int>(type: "int", nullable: false),
                    YearlyPlacementOrderQuantity = table.Column<int>(type: "int", nullable: false),
                    DateOfPlacementOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EProcurementPaymentAccountNumber = table.Column<int>(type: "int", nullable: false),
                    ProcurementPaymentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfFirstPayment = table.Column<int>(type: "int", nullable: false),
                    AmountOfSecondPayment = table.Column<int>(type: "int", nullable: false),
                    ReceivedDateOfFirstPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedDateOfSecondPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMonthlyEXpenditure = table.Column<int>(type: "int", nullable: false),
                    TotalYearlyEXpenditure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procurements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Procurements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffLog2",
                table: "StaffLog2");

            migrationBuilder.RenameTable(
                name: "StaffLog2",
                newName: "staffLog2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staffLog2",
                table: "staffLog2",
                column: "id");
        }
    }
}
