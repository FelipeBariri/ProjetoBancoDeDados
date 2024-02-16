using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoBancoDeDados.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    PagamentosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.PagamentosId);
                });

            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    PassagensId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.PassagensId);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoEvento",
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
                    table.PrimaryKey("PK_ProjetoEvento", x => x.EventosId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Inscricoes",
                columns: table => new
                {
                    InscricoesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventosId = table.Column<int>(type: "int", nullable: false),
                    PagamentosId = table.Column<int>(type: "int", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false),
                    PassagensId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricoes", x => x.InscricoesId);
                    table.ForeignKey(
                        name: "FK_Inscricoes_Pagamentos_PagamentosId",
                        column: x => x.PagamentosId,
                        principalTable: "Pagamentos",
                        principalColumn: "PagamentosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscricoes_Passagens_PassagensId",
                        column: x => x.PassagensId,
                        principalTable: "Passagens",
                        principalColumn: "PassagensId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscricoes_ProjetoEvento_EventosId",
                        column: x => x.EventosId,
                        principalTable: "ProjetoEvento",
                        principalColumn: "EventosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscricoes_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_EventosId",
                table: "Inscricoes",
                column: "EventosId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_PagamentosId",
                table: "Inscricoes",
                column: "PagamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_PassagensId",
                table: "Inscricoes",
                column: "PassagensId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_UsuariosId",
                table: "Inscricoes",
                column: "UsuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscricoes");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "Passagens");

            migrationBuilder.DropTable(
                name: "ProjetoEvento");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
