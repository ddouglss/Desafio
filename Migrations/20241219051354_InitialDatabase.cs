using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppTeste.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ring",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Portador = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ForjadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ring", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ring");
        }
    }
}
