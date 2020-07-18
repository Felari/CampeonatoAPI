using Microsoft.EntityFrameworkCore.Migrations;

namespace Campeonato.Infra.Data.Migrations
{
    public partial class Primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampeonatoSydy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoSydy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeId = table.Column<int>(nullable: false),
                    CampeonatoId = table.Column<int>(nullable: false),
                    Pontuacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participante_CampeonatoSydy_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "CampeonatoSydy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participante_Time_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampeonatoId = table.Column<int>(nullable: false),
                    TimeVisitanteId = table.Column<int>(nullable: false),
                    TimeCasaId = table.Column<int>(nullable: false),
                    GolTimeVisitante = table.Column<int>(nullable: false),
                    GolTimeCasa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partida_CampeonatoSydy_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "CampeonatoSydy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partida_Time_TimeCasaId",
                        column: x => x.TimeCasaId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partida_Time_TimeVisitanteId",
                        column: x => x.TimeVisitanteId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CampeonatoSydy",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Sydy Championship" });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Sydy Novo" },
                    { 2, "Concorrente" },
                    { 3, "Visitante" },
                    { 4, "Time Flopado" },
                    { 5, "Time Hypado" }
                });

            migrationBuilder.InsertData(
                table: "Participante",
                columns: new[] { "Id", "CampeonatoId", "Pontuacao", "TimeId" },
                values: new object[,]
                {
                    { 1, 1, 0, 1 },
                    { 2, 1, 0, 2 },
                    { 3, 1, 0, 3 },
                    { 4, 1, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Partida",
                columns: new[] { "Id", "CampeonatoId", "GolTimeCasa", "GolTimeVisitante", "TimeCasaId", "TimeVisitanteId" },
                values: new object[,]
                {
                    { 1, 1, 6, 5, 1, 2 },
                    { 2, 1, 8, 5, 1, 3 },
                    { 4, 1, 2, 8, 2, 3 },
                    { 3, 1, 5, 3, 1, 4 },
                    { 5, 1, 9, 0, 2, 4 },
                    { 6, 1, 9, 2, 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participante_CampeonatoId",
                table: "Participante",
                column: "CampeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_TimeId",
                table: "Participante",
                column: "TimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_CampeonatoId",
                table: "Partida",
                column: "CampeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_TimeCasaId",
                table: "Partida",
                column: "TimeCasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_TimeVisitanteId",
                table: "Partida",
                column: "TimeVisitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_Nome",
                table: "Time",
                column: "Nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participante");

            migrationBuilder.DropTable(
                name: "Partida");

            migrationBuilder.DropTable(
                name: "CampeonatoSydy");

            migrationBuilder.DropTable(
                name: "Time");
        }
    }
}
