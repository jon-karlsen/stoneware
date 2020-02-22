using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesOutstandingSingleProdAllVerTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingSingleProdAllVerTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(2, 5)]
        [InlineData(3, 8)]
        [InlineData(4, 7)]
        public async Task TestIssuesOutstandingSingleProductAllVersionsProductIdValid(int testId, int expectedAmt)
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", testId)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedAmt, result.Count);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProductAllVersionsProductIdInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", 666)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerProductIdBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", "bad")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerProductIdNull()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", null)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerArgInjection()
        {
            // Arrange
            const string input = "DROP TABLE dbo.Issues";

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", input)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
    }
}