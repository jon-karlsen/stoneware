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
    public class IssuesResolvedKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }


        [Fact]
        public async Task TestIssuesResolvedKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedKeywords")
                .WithSqlParam("@Keywords", "PCI")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Contains(result, r => r.Problem.LastIndexOf("PCI", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesResolvedKeywordsArgsMultiple()
        {
            // Arrange

            var result = await _context
                .LoadStoredProc("spIssuesResolvedKeywords")
                .WithSqlParam("@Keywords", "SSL, HDD")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("SSL", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("HDD", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}