using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Challenge5_PetAdoptionAPICThomason.Migrations
{
    /// <inheritdoc />
    public partial class FixedId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staff",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Staff",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsWorking",
                table: "Staff",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "JobPosition",
                table: "Staff",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Staff",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Staff",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "IsWorking",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "JobPosition",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Staff");
        }
    }
}
