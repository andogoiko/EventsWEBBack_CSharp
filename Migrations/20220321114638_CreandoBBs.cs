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
                    categoria_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion_categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.categoria_id);
                });

            migrationBuilder.CreateTable(
                name: "Localizaciones",
                columns: table => new
                {
                    localizacion_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    localizacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latitud = table.Column<double>(type: "float", nullable: false),
                    longitud = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizaciones", x => x.localizacion_id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    usuario_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_Usuarios", x => x.usuario_id);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    evento_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    evento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_inic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora_inic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora_fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    localizacion_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria_id1 = table.Column<int>(type: "int", nullable: true),
                    localizacion_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.evento_id);
                    table.ForeignKey(
                        name: "FK_Eventos_Categorias_categoria_id1",
                        column: x => x.categoria_id1,
                        principalTable: "Categorias",
                        principalColumn: "categoria_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Eventos_Localizaciones_localizacion_id1",
                        column: x => x.localizacion_id1,
                        principalTable: "Localizaciones",
                        principalColumn: "localizacion_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    comentario_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comentario_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    evento_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuario_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_comentario = table.Column<int>(type: "int", nullable: false),
                    usuario_id1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    evento_id1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.comentario_id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Eventos_evento_id1",
                        column: x => x.evento_id1,
                        principalTable: "Eventos",
                        principalColumn: "evento_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_usuario_id1",
                        column: x => x.usuario_id1,
                        principalTable: "Usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    inscripcion_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    evento_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valoracion = table.Column<int>(type: "int", nullable: false),
                    usuario_id1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    evento_id1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.inscripcion_id);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Eventos_evento_id1",
                        column: x => x.evento_id1,
                        principalTable: "Eventos",
                        principalColumn: "evento_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Usuarios_usuario_id1",
                        column: x => x.usuario_id1,
                        principalTable: "Usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_evento_id1",
                table: "Comentarios",
                column: "evento_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_usuario_id1",
                table: "Comentarios",
                column: "usuario_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_categoria_id1",
                table: "Eventos",
                column: "categoria_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_localizacion_id1",
                table: "Eventos",
                column: "localizacion_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_evento_id1",
                table: "Inscripciones",
                column: "evento_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_usuario_id1",
                table: "Inscripciones",
                column: "usuario_id1");
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
