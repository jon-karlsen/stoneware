using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesResolvedSingleProdSingleVerDateRangeTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedSingleProdSingleVerDateRangeTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerDateRangeArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVerDateRange")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        
        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerDateRangeArgsValid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVerDateRange")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@VersionNumberId", 2)
                .WithSqlParam("@OperatingSystemId", 4)
                .WithSqlParam("@StartDate", "2020-02-15")
                .WithSqlParam("@EndDate", "2020-02-17")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
        }

        [Theory]
        [InlineData(5, 1, 1, "2020-02-09", "2020-02-11")]
        [InlineData(1, 666, 1, "2020-02-09", "2020-02-11")]
        [InlineData(1, 1, 666, "2020-02-09", "2020-02-11")]
        [InlineData(1, 1, 1, "2022-02-09", "2022-02-11")]
        [InlineData(1, 1, 1, "2020-02-09", "2020-02-09")]
        public async Task TestIssuesResolvedSingleProdSingleVerDateRangeProductIdInvalid(int testProdId, int testVerNoId,
            int testOsId, string testStartDate, string testEndDate)
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVerDateRange")
                .WithSqlParam("@ProductId", testProdId)
                .WithSqlParam("@VersionNumberId", testVerNoId)
                .WithSqlParam("@OperatingSystemId", testOsId)
                .WithSqlParam("@StartDate", testStartDate)
                .WithSqlParam("@EndDate", testEndDate)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(null, "1", "1", "2020-02-09", "2020-02-11")]
        [InlineData("1", null, "1", "2020-02-09", "2020-02-11")]
        [InlineData("1", "1", null, "2020-02-09", "2020-02-11")]
        [InlineData("1", "1", "1", null, "2020-02-11")]
        [InlineData("1", "1", "1", "2020-02-09", null)]
        [InlineData("test", "1", "1", "2020-02-09", "2020-02-11")]
        [InlineData("1", "test", "1", "2020-02-09", "2020-02-11")]
        [InlineData("1", "1", "test", "2020-02-09", "2020-02-11")]
        [InlineData("1", "1", "1", "test", "2020-02-11")]
        [InlineData("1", "1", "1", "2020-02-09", "test")]
        public async Task TestIssuesOutstandingSingleProdSingleVerDateRangeProductIdBad(string testProdId, string testVerNoId,
            string testOsId, string testStartDate, string testEndDate)
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVerDateRange")
                .WithSqlParam("@ProductId", testProdId)
                .WithSqlParam("@VersionNumberId", testVerNoId)
                .WithSqlParam("@OperatingSystemId", testOsId)
                .WithSqlParam("@StartDate", testStartDate)
                .WithSqlParam("@EndDate", testEndDate)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
    }
}