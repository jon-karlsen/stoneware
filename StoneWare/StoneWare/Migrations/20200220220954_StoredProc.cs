using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class StoredProc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ExecuteSqlFromEmbeddedResources(migrationBuilder);
        }

        private static void ExecuteSqlFromEmbeddedResources(MigrationBuilder migrationBuilder)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var resourceNames =
                assembly.GetManifestResourceNames().Where(str => str.EndsWith(".sql"));

            foreach (var resourceName in resourceNames)
            {
                using (var stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new StreamReader(stream))
                {
                    var sql = reader.ReadToEnd();
                    migrationBuilder.Sql(sql);
                }
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            return;
        }
    }
}
