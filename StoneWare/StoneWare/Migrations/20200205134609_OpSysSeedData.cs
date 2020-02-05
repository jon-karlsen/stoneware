using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class OpSysSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OperatingSystem",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Linux" },
                    { 2, "MacOS" },
                    { 3, "Windows" },
                    { 4, "Android" },
                    { 5, "iOS" },
                    { 6, "Windows Mobile" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperatingSystem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperatingSystem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperatingSystem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperatingSystem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperatingSystem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperatingSystem",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
