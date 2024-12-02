using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceTracking.Dal.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Device");

            migrationBuilder.CreateTable(
                name: "Cihaz",
                schema: "Device",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cihaz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                schema: "Device",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CihazParca",
                schema: "Device",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CihazParca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CihazParca_Cihaz_CihazId",
                        column: x => x.CihazId,
                        principalSchema: "Device",
                        principalTable: "Cihaz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CihazParca_CihazId",
                schema: "Device",
                table: "CihazParca",
                column: "CihazId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CihazParca",
                schema: "Device");

            migrationBuilder.DropTable(
                name: "Kullanici",
                schema: "Device");

            migrationBuilder.DropTable(
                name: "Cihaz",
                schema: "Device");
        }
    }
}
