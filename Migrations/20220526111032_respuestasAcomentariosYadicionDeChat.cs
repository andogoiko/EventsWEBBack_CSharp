using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyectoFinal.Migrations
{
    public partial class respuestasAcomentariosYadicionDeChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "respuesta",
                table: "Comentarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Conversacion",
                columns: table => new
                {
                    conversacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreConversacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversacion", x => x.conversacionId);
                });

            migrationBuilder.CreateTable(
                name: "ConversacionUsuario",
                columns: table => new
                {
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    conversacionId = table.Column<int>(type: "int", nullable: false),
                    fechaAnyadido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaAbandono = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversacionUsuario", x => new { x.usuarioId, x.conversacionId });
                    table.ForeignKey(
                        name: "FK_ConversacionUsuario_Conversacion_conversacionId",
                        column: x => x.conversacionId,
                        principalTable: "Conversacion",
                        principalColumn: "conversacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConversacionUsuario_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mensaje",
                columns: table => new
                {
                    mensajeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    conversacionId = table.Column<int>(type: "int", nullable: false),
                    mensajeTexto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaEnviado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensaje", x => x.mensajeId);
                    table.ForeignKey(
                        name: "FK_Mensaje_Conversacion_conversacionId",
                        column: x => x.conversacionId,
                        principalTable: "Conversacion",
                        principalColumn: "conversacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mensaje_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConversacionUsuario_conversacionId",
                table: "ConversacionUsuario",
                column: "conversacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensaje_conversacionId",
                table: "Mensaje",
                column: "conversacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensaje_usuarioId",
                table: "Mensaje",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversacionUsuario");

            migrationBuilder.DropTable(
                name: "Mensaje");

            migrationBuilder.DropTable(
                name: "Conversacion");

            migrationBuilder.DropColumn(
                name: "respuesta",
                table: "Comentarios");
        }
    }
}
