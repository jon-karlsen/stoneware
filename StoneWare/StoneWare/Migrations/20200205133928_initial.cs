using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperatingSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VersionNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionNumber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVersionOs",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    OperatingSystemId = table.Column<int>(nullable: false),
                    VersionNumberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVersionOs", x => new { x.ProductId, x.OperatingSystemId, x.VersionNumberId });
                    table.ForeignKey(
                        name: "FK_ProductVersionOs_OperatingSystem",
                        column: x => x.OperatingSystemId,
                        principalTable: "OperatingSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVersionOs_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVersionOs_VersionNumber",
                        column: x => x.VersionNumberId,
                        principalTable: "VersionNumber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    VersionNumberId = table.Column<int>(nullable: false),
                    OperatingSystemId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    TimeLastUpdated = table.Column<DateTime>(type: "datetime", nullable: false),
                    Problem = table.Column<string>(maxLength: 1000, nullable: false),
                    Resolution = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Issue_Status",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Issue_ProductVersionOs",
                        columns: x => new { x.ProductId, x.OperatingSystemId, x.VersionNumberId },
                        principalTable: "ProductVersionOs",
                        principalColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issue_StatusId",
                table: "Issue",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Issue_ProductId_OperatingSystemId_VersionNumberId",
                table: "Issue",
                columns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOs_OperatingSystemId",
                table: "ProductVersionOs",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOs_VersionNumberId",
                table: "ProductVersionOs",
                column: "VersionNumberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issue");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "ProductVersionOs");

            migrationBuilder.DropTable(
                name: "OperatingSystem");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "VersionNumber");
        }
    }
}
