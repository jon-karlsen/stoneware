using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesResolvedSingleProdAllVerTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedSingleProdAllVerTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Theory]
        [InlineData(1, 10)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 8)]
        public async Task TestIssuesResolvedSingleProductAllVersionsProductIdValid(int testId, int expectedAmt)
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", testId)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedAmt, result.Count);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProductAllVersionsProductIdInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", 666)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerArgumentNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerProductIdBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", "bad")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerProductIdNull()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", null)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerArgInjection()
        {
            // Arrange
            const string input = "DROP TABLE dbo.Issues";

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", input)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
    }
}