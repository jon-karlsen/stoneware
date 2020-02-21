using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class ProductVerNoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductVersionOs",
                columns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 1, 1 },
                    { 3, 2, 1 },
                    { 3, 1, 2 },
                    { 3, 2, 2 },
                    { 3, 3, 2 },
                    { 3, 4, 2 },
                    { 3, 5, 2 },
                    { 3, 6, 2 },
                    { 3, 2, 5 },
                    { 3, 3, 5 },
                    { 3, 4, 5 },
                    { 3, 5, 5 },
                    { 4, 2, 1 },
                    { 4, 3, 1 },
                    { 4, 4, 1 },
                    { 4, 5, 1 },
                    { 4, 6, 1 },
                    { 4, 2, 2 },
                    { 4, 3, 2 },
                    { 2, 5, 6 },
                    { 4, 4, 2 },
                    { 2, 4, 6 },
                    { 2, 2, 6 },
                    { 1, 3, 1 },
                    { 1, 1, 2 },
                    { 1, 2, 2 },
                    { 1, 3, 2 },
                    { 1, 1, 3 },
                    { 1, 2, 3 },
                    { 1, 3, 3 },
                    { 1, 4, 3 },
                    { 1, 5, 3 },
                    { 1, 6, 3 },
                    { 1, 2, 4 },
                    { 1, 3, 4 },
                    { 1, 4, 4 },
                    { 1, 5, 4 },
                    { 2, 2, 1 },
                    { 2, 5, 1 },
                    { 2, 2, 5 },
                    { 2, 4, 5 },
                    { 2, 5, 5 },
                    { 2, 3, 6 },
                    { 4, 5, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 1, 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 4, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 2, 5, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 3, 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVersionOs",
                keyColumns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                keyValues: new object[] { 4, 6, 1 });
        }
    }
}
