using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FebBatch2026WebApi.Migrations
{
    /// <inheritdoc />
    public partial class EmpManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "managers",
                columns: table => new
                {
                    mid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managers", x => x.mid);
                });

            migrationBuilder.CreateTable(
                name: "emps",
                columns: table => new
                {
                    eid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    esalary = table.Column<double>(type: "float", nullable: false),
                    mid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emps", x => x.eid);
                    table.ForeignKey(
                        name: "FK_emps_managers_mid",
                        column: x => x.mid,
                        principalTable: "managers",
                        principalColumn: "mid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emps_mid",
                table: "emps",
                column: "mid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emps");

            migrationBuilder.DropTable(
                name: "managers");
        }
    }
}
