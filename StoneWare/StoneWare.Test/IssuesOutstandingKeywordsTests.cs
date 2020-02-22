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
    public class IssuesOutstandingKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .WithSqlParam("@Keywords", "CSS")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgsMultiple()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .WithSqlParam("@Keywords", "css, sdd, json")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(6, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("SDD", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("JSON", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgNull()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .WithSqlParam("@Keywords", null)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
    }
}