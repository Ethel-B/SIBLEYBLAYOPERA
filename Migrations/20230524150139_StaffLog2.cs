using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class StaffLog2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "staffLog2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    RoleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffIDNumber = table.Column<int>(type: "int", nullable: false),
                    ContractAgreement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractAgreementExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrossWage = table.Column<int>(type: "int", nullable: false),
                    NetWage = table.Column<int>(type: "int", nullable: false),
                    ModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EWageAccountNumber = table.Column<int>(type: "int", nullable: false),
                    NetWageAccounting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SocialSecurityAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialSecurityWage = table.Column<int>(type: "int", nullable: false),
                    SocialSecurityModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialSecurityEWageAccountNumber = table.Column<int>(type: "int", nullable: false),
                    SocialSecurityWageAccounting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VacationDays = table.Column<int>(type: "int", nullable: false),
                    NumberOfExhaustedVacationDays = table.Column<int>(type: "int", nullable: false),
                    NumberOfUnExhaustedVacationDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffLog2", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staffLog2");
        }
    }
}
