using Microsoft.EntityFrameworkCore.Migrations;

namespace proyectoFinal.Migrations
{
    public partial class CreandoBBs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    categoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion_categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.categoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Localizaciones",
                columns: table => new
                {
                    localizacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    localizacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    administrator = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
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
                    eventoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    evento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_inic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora_inic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora_fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    localizacionId = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aforo_max = table.Column<int>(type: "int", nullable: false),
                    popularidad = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    precio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriaId = table.Column<int>(type: "int", nullable: false)
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
                    comentario_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventoId = table.Column<int>(type: "int", nullable: false),
                    categoriaId = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    fecha_comentario = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    inscripcionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    eventoId = table.Column<int>(type: "int", nullable: false),
                    valoracion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.inscripcionId);
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

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_usuarioId",
                table: "Usuarios",
                column: "usuarioId",
                unique: true);
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
