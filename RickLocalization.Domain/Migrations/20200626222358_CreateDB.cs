using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RickLocalization.Domain.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimensoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Descricao = table.Column<string>(type: "VARCHAR(1000)", nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viajantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Imagem = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    DimensaoId = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viajantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viajantes_Dimensoes_DimensaoId",
                        column: x => x.DimensaoId,
                        principalTable: "Dimensoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogsViagens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViajanteId = table.Column<int>(nullable: false),
                    DimensaoOrigemId = table.Column<int>(nullable: false),
                    DimensaoDestinoId = table.Column<int>(nullable: false),
                    DataViagem = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsViagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogsViagens_Viajantes_ViajanteId",
                        column: x => x.ViajanteId,
                        principalTable: "Viajantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogsViagens_ViajanteId",
                table: "LogsViagens",
                column: "ViajanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Viajantes_DimensaoId",
                table: "Viajantes",
                column: "DimensaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogsViagens");

            migrationBuilder.DropTable(
                name: "Viajantes");

            migrationBuilder.DropTable(
                name: "Dimensoes");
        }
    }
}
