using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReyphillDuarte_AP1_P2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    EntidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sueldo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.EntidadId);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<int>(type: "int", nullable: false),
                    Modelo_ExamenEntidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_Detalles_Modelo_Modelo_ExamenEntidadId",
                        column: x => x.Modelo_ExamenEntidadId,
                        principalTable: "Modelo",
                        principalColumn: "EntidadId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Modelo_ExamenEntidadId",
                table: "Detalles",
                column: "Modelo_ExamenEntidadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Modelo");
        }
    }
}
