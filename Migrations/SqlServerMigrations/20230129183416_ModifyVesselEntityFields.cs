using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations.SqlServerMigrations
{
    public partial class ModifyVesselEntityFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Vessels",
                newName: "YearOfConstruction");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vessels",
                newName: "VesselNumber");

            migrationBuilder.AlterColumn<double>(
                name: "Width",
                table: "Vessels",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Length",
                table: "Vessels",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearOfConstruction",
                table: "Vessels",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "VesselNumber",
                table: "Vessels",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "Vessels",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Length",
                table: "Vessels",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
