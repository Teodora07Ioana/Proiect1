using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect1.Migrations
{
    /// <inheritdoc />
    public partial class Servicee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Stylist_StylistID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Service",
                table: "Appointment");

            migrationBuilder.AlterColumn<int>(
                name: "StylistID",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ServiceID",
                table: "Appointment",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Service_ServiceID",
                table: "Appointment",
                column: "ServiceID",
                principalTable: "Service",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Stylist_StylistID",
                table: "Appointment",
                column: "StylistID",
                principalTable: "Stylist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Service_ServiceID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Stylist_StylistID",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_ServiceID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "Appointment");

            migrationBuilder.AlterColumn<int>(
                name: "StylistID",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Stylist_StylistID",
                table: "Appointment",
                column: "StylistID",
                principalTable: "Stylist",
                principalColumn: "ID");
        }
    }
}
