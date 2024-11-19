using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dimithrius004.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SistCod = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    Branch = table.Column<int>(type: "INTEGER", nullable: false),
                    City = table.Column<int>(type: "INTEGER", nullable: false),
                    Country = table.Column<int>(type: "INTEGER", nullable: false),
                    MunicipalRegister = table.Column<string>(type: "TEXT", nullable: true),
                    StateRegister = table.Column<string>(type: "TEXT", nullable: true),
                    MunicipalLogin = table.Column<string>(type: "TEXT", nullable: true),
                    MunicipalPassword = table.Column<string>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    Taxation = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
