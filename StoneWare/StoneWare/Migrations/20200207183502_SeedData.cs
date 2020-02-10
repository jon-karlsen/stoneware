using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersionOs_OperatingSystem",
                table: "ProductVersionOs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersionOs_Product",
                table: "ProductVersionOs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersionOs_VersionNumber",
                table: "ProductVersionOs");

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

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Social Anxiety Planner" },
                    { 3, "Workout Planner" },
                    { 1, "Day Trader Wannabe" },
                    { 2, "Investment Overlord" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "Resolved" }
                });

            migrationBuilder.InsertData(
                table: "VersionNumber",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 5, "2.0" },
                    { 1, "1.0" },
                    { 2, "1.1" },
                    { 3, "1.2" },
                    { 4, "1.3" },
                    { 6, "2.1" }
                });

            migrationBuilder.InsertData(
                table: "ProductVersionOs",
                columns: new[] { "ProductId", "OperatingSystemId", "VersionNumberId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
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
                    { 2, 2, 5 },
                    { 2, 4, 5 },
                    { 2, 5, 5 },
                    { 3, 2, 5 },
                    { 3, 3, 5 },
                    { 3, 4, 5 },
                    { 3, 5, 5 },
                    { 2, 2, 6 },
                    { 2, 3, 6 },
                    { 4, 5, 2 },
                    { 2, 4, 6 },
                    { 4, 4, 2 },
                    { 4, 2, 2 },
                    { 1, 3, 1 },
                    { 2, 2, 1 },
                    { 2, 5, 1 },
                    { 3, 1, 1 },
                    { 3, 2, 1 },
                    { 4, 2, 1 },
                    { 4, 3, 1 },
                    { 4, 4, 1 },
                    { 4, 5, 1 },
                    { 4, 6, 1 },
                    { 1, 1, 2 },
                    { 1, 2, 2 },
                    { 1, 3, 2 },
                    { 3, 1, 2 },
                    { 3, 2, 2 },
                    { 3, 3, 2 },
                    { 3, 4, 2 },
                    { 3, 5, 2 },
                    { 3, 6, 2 },
                    { 4, 3, 2 },
                    { 2, 5, 6 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersionOs_OperatingSystem",
                table: "ProductVersionOs",
                column: "OperatingSystemId",
                principalTable: "OperatingSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersionOs_Product",
                table: "ProductVersionOs",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersionOs_VersionNumber",
                table: "ProductVersionOs",
                column: "VersionNumberId",
                principalTable: "VersionNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersionOs_OperatingSystem",
                table: "ProductVersionOs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersionOs_Product",
                table: "ProductVersionOs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersionOs_VersionNumber",
                table: "ProductVersionOs");

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

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersionOs_OperatingSystem",
                table: "ProductVersionOs",
                column: "OperatingSystemId",
                principalTable: "OperatingSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersionOs_Product",
                table: "ProductVersionOs",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersionOs_VersionNumber",
                table: "ProductVersionOs",
                column: "VersionNumberId",
                principalTable: "VersionNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
