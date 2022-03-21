using Microsoft.EntityFrameworkCore.Migrations;

namespace proyectoFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    categoriaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    descripcionCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.categoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Localizaciones",
                columns: table => new
                {
                    localizacionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    latitud = table.Column<double>(type: "float", nullable: false),
                    longitud = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizaciones", x => x.localizacionId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    usuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.usuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    eventoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fechaInic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaFin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horaInic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horaFin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    localizacionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriaId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.eventoId);
                    table.ForeignKey(
                        name: "FK_Eventos_Categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "Categorias",
                        principalColumn: "categoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eventos_Localizaciones_localizacionId",
                        column: x => x.localizacionId,
                        principalTable: "Localizaciones",
                        principalColumn: "localizacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    comentarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comentarioText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    categoriaId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fechaComentario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.comentarioId);
                    table.ForeignKey(
                        name: "FK_Comentarios_Eventos_eventoId",
                        column: x => x.eventoId,
                        principalTable: "Eventos",
                        principalColumn: "eventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    eventoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    valoracion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.InscripcionId);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Eventos_eventoId",
                        column: x => x.eventoId,
                        principalTable: "Eventos",
                        principalColumn: "eventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_eventoId",
                table: "Comentarios",
                column: "eventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_usuarioId",
                table: "Comentarios",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_categoriaId",
                table: "Eventos",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_localizacionId",
                table: "Eventos",
                column: "localizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_eventoId",
                table: "Inscripciones",
                column: "eventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_usuarioId",
                table: "Inscripciones",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Inscripciones");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Localizaciones");
        }
    }
}
