using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class EventsLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventsLog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolePerformers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfRolePerformer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleOfRolePerformer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDetails = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AudienceSeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    ExpectedAudienceSeatingNo = table.Column<int>(type: "int", nullable: false),
                    UnExpectedAudienceSeatingNo = table.Column<int>(type: "int", nullable: false),
                    EventPrice = table.Column<int>(type: "int", nullable: false),
                    TotalMonthlyExpenditure = table.Column<int>(type: "int", nullable: false),
                    TotalYearlyExpenditure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsLog", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventsLog");
        }
    }
}
