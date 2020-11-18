using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    endereco = table.Column<string>(nullable: true),
                    numero = table.Column<int>(nullable: false),
                    bairro = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    uf = table.Column<string>(nullable: true),
                    cep = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Proprietario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    enderecoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Proprietario_Endereco_enderecoid",
                        column: x => x.enderecoid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    area = table.Column<int>(nullable: false),
                    terreno = table.Column<int>(nullable: false),
                    numQuartos = table.Column<int>(nullable: false),
                    numBanheiro = table.Column<int>(nullable: false),
                    andar = table.Column<string>(nullable: true),
                    vagas = table.Column<int>(nullable: false),
                    urlImagem = table.Column<string>(nullable: true),
                    proprietarioid = table.Column<int>(nullable: true),
                    enderecoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.id);
                    table.ForeignKey(
                        name: "FK_Imovel_Endereco_enderecoid",
                        column: x => x.enderecoid,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imovel_Proprietario_proprietarioid",
                        column: x => x.proprietarioid,
                        principalTable: "Proprietario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "id", "password", "user" },
                values: new object[] { 1, "123", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_enderecoid",
                table: "Imovel",
                column: "enderecoid");

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_proprietarioid",
                table: "Imovel",
                column: "proprietarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietario_enderecoid",
                table: "Proprietario",
                column: "enderecoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Proprietario");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
