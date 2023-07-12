using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class TaxExpendituresLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaxExpendituresLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfTax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalYearlyExpenditure = table.Column<int>(type: "int", nullable: false),
                    TaxPaymentLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClearedAmount = table.Column<int>(type: "int", nullable: false),
                    UnClearedAmount = table.Column<int>(type: "int", nullable: false),
                    ModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecondPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountOfFirstPayment = table.Column<int>(type: "int", nullable: false),
                    AmountOfSecondPayment = table.Column<int>(type: "int", nullable: false),
                    TaxReceiptIDNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxExpendituresLog", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxExpendituresLog");
        }
    }
}
