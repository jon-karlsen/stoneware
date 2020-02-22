using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesOutstandingSingleProdSingleVerTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingSingleProdSingleVerTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgumentsValid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@VersionNumberId", 1)
                .WithSqlParam("@OperatingSystemId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgumentsInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                .WithSqlParam("@ProductId", 5)
                .WithSqlParam("@VersionNumberId", 1)
                .WithSqlParam("@OperatingSystemId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgumentsBad()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", "string")
                    .WithSqlParam("@OperatingSystemId", 1)
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgumentsNull()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", 1)
                    .WithSqlParam("@OperatingSystemId", null)
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgumentsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgsInjection()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", 1)
                    .WithSqlParam("@OperatingSystemId", null)
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }
    }
}