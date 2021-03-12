using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMDL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserHp = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Fluffymons",
                columns: table => new
                {
                    FluffymonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fluffiness = table.Column<int>(type: "integer", nullable: false),
                    FluffymonName = table.Column<string>(type: "text", nullable: true),
                    AES = table.Column<int>(type: "integer", nullable: false),
                    MGTR = table.Column<int>(type: "integer", nullable: false),
                    Element = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluffymons", x => x.FluffymonId);
                    table.ForeignKey(
                        name: "FK_Fluffymons_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFluffymons",
                columns: table => new
                {
                    UserFluffymonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FluffymonId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFluffymons", x => x.UserFluffymonId);
                    table.ForeignKey(
                        name: "FK_UserFluffymons_Fluffymons_FluffymonId",
                        column: x => x.FluffymonId,
                        principalTable: "Fluffymons",
                        principalColumn: "FluffymonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFluffymons_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluffymons_UserId",
                table: "Fluffymons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFluffymons_FluffymonId",
                table: "UserFluffymons",
                column: "FluffymonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFluffymons_UserId",
                table: "UserFluffymons",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFluffymons");

            migrationBuilder.DropTable(
                name: "Fluffymons");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
