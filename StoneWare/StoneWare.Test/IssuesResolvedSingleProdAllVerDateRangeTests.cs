using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesResolvedSingleProdAllVerDateRangeTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedSingleProdAllVerDateRangeTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerDateRange()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", "2020-02-15")
                .WithSqlParam("@EndDate", "2020-02-17")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Equal(10, result.Count);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerDateRangeArgumentsDateNone()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerDateRangeArgumentsBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", "2020-02-09-09-09")
                .WithSqlParam("@EndDate", "2020-02-11-09-09")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
    }
}