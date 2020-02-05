using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class VerNoSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VersionNumber",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "1.0" },
                    { 2, "1.1" },
                    { 3, "1.2" },
                    { 4, "1.3" },
                    { 5, "2.0" },
                    { 6, "2.1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VersionNumber",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VersionNumber",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VersionNumber",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VersionNumber",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VersionNumber",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VersionNumber",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
