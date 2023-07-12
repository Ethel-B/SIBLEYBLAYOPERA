using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "TaxExpendituresLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "StaffLog1",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Procurements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "EventsLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "DepartmentalProcurements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Collaborations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaxExpendituresLog_UsersId",
                table: "TaxExpendituresLog",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffLog1_UsersId",
                table: "StaffLog1",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_UsersId",
                table: "Procurements",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_EventsLog_UsersId",
                table: "EventsLog",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentalProcurements_UsersId",
                table: "DepartmentalProcurements",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborations_UsersId",
                table: "Collaborations",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UsersId",
                table: "Bookings",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UsersId",
                table: "Bookings",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborations_Users_UsersId",
                table: "Collaborations",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentalProcurements_Users_UsersId",
                table: "DepartmentalProcurements",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventsLog_Users_UsersId",
                table: "EventsLog",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Procurements_Users_UsersId",
                table: "Procurements",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffLog1_Users_UsersId",
                table: "StaffLog1",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxExpendituresLog_Users_UsersId",
                table: "TaxExpendituresLog",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UsersId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Collaborations_Users_UsersId",
                table: "Collaborations");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentalProcurements_Users_UsersId",
                table: "DepartmentalProcurements");

            migrationBuilder.DropForeignKey(
                name: "FK_EventsLog_Users_UsersId",
                table: "EventsLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Procurements_Users_UsersId",
                table: "Procurements");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffLog1_Users_UsersId",
                table: "StaffLog1");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxExpendituresLog_Users_UsersId",
                table: "TaxExpendituresLog");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_TaxExpendituresLog_UsersId",
                table: "TaxExpendituresLog");

            migrationBuilder.DropIndex(
                name: "IX_StaffLog1_UsersId",
                table: "StaffLog1");

            migrationBuilder.DropIndex(
                name: "IX_Procurements_UsersId",
                table: "Procurements");

            migrationBuilder.DropIndex(
                name: "IX_EventsLog_UsersId",
                table: "EventsLog");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentalProcurements_UsersId",
                table: "DepartmentalProcurements");

            migrationBuilder.DropIndex(
                name: "IX_Collaborations_UsersId",
                table: "Collaborations");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UsersId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "TaxExpendituresLog");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "StaffLog1");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Procurements");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "EventsLog");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "DepartmentalProcurements");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Collaborations");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Bookings");
        }
    }
}
