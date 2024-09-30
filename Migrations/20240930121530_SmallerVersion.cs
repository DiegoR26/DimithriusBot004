using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dimithrius004.Migrations
{
    /// <inheritdoc />
    public partial class SmallerVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MunicipalTaxes",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "StateTaxes",
                table: "Clients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MunicipalTaxes",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StateTaxes",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
