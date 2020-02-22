using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesResolvedSingleProdSingleVerTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedSingleProdSingleVerTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgumentsValid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@VersionNumberId", 2)
                .WithSqlParam("@OperatingSystemId", 4)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgumentsInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                .WithSqlParam("@ProductId", 5)
                .WithSqlParam("@VersionNumberId", 1)
                .WithSqlParam("@OperatingSystemId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgumentsBad()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", "string")
                    .WithSqlParam("@OperatingSystemId", 1)
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgumentsNull()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", 1)
                    .WithSqlParam("@OperatingSystemId", null)
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgumentsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgsInjection()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", 1)
                    .WithSqlParam("@OperatingSystemId", null)
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }
    }
}