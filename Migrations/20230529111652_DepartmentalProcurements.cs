using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentalProcurements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentalProcurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Middlename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffIDNumber = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderQuantity = table.Column<int>(type: "int", nullable: false),
                    PresentQuantity = table.Column<int>(type: "int", nullable: false),
                    AbsentQuantity = table.Column<int>(type: "int", nullable: false),
                    ProcurementCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyPlacementOrderQuantity = table.Column<int>(type: "int", nullable: false),
                    YearlyPlacementOrderQuantity = table.Column<int>(type: "int", nullable: false),
                    DateOfPlacementOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentalProcurements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentalProcurements");
        }
    }
}
