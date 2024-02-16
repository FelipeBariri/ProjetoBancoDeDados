using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoBancoDeDados.Migrations
{
    /// <inheritdoc />
    public partial class Atualizaçãofinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscricoes_ProjetoEvento_EventosId",
                table: "Inscricoes");

            migrationBuilder.DropTable(
                name: "ProjetoEvento");

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEventoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEventoId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescricaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventosId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Inscricoes_Eventos_EventosId",
                table: "Inscricoes",
                column: "EventosId",
                principalTable: "Eventos",
                principalColumn: "EventosId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscricoes_Eventos_EventosId",
                table: "Inscricoes");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.CreateTable(
                name: "ProjetoEvento",
                columns: table => new
                {
                    EventosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEventoId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescricaoId = table.Column<int>(type: "int", nullable: false),
                    NomeEventoId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoEvento", x => x.EventosId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Inscricoes_ProjetoEvento_EventosId",
                table: "Inscricoes",
                column: "EventosId",
                principalTable: "ProjetoEvento",
                principalColumn: "EventosId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
