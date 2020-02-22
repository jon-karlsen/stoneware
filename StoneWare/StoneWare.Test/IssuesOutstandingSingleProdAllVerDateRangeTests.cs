using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesOutstandingSingleProdAllVerDateRangeTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingSingleProdAllVerDateRangeTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeArgsValid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", new DateTime(2020, 02, 15))
                .WithSqlParam("@EndDate", new DateTime(2020, 02, 17))
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Equal(5, result.Count);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeArgumentsDateNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeArgumentsBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", "2020-02-09-09-09")
                .WithSqlParam("@EndDate", "2020-02-11-09-09")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeStartDateNull()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", null)
                .WithSqlParam("@EndDate", "2020-02-11")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeEndDateNull()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", "2020-02-09")
                .WithSqlParam("@EndDate", null)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
    }
}