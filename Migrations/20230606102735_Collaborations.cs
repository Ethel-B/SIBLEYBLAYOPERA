using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class Collaborations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collaborations",
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
                    RoleStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractAgreement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractAgreementExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgreedContractPayment = table.Column<int>(type: "int", nullable: false),
                    AgreedPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HonouredContractPayment1 = table.Column<int>(type: "int", nullable: false),
                    HonouredContractPayment2 = table.Column<int>(type: "int", nullable: false),
                    UnHonouredContractPayment1 = table.Column<int>(type: "int", nullable: false),
                    UnHonouredContractPayment2 = table.Column<int>(type: "int", nullable: false),
                    HonouredPayment1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HonouredPayment2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnHonouredPayment1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnHonouredPayment2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EContractPaymentAccountNumber = table.Column<int>(type: "int", nullable: false),
                    ContractPaymentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborations", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collaborations");
        }
    }
}
