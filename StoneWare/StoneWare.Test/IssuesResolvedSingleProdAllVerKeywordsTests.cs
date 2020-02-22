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
    public class IssuesResolvedSingleProdAllVerKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedSingleProdAllVerKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@Keywords", "COM")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.DoesNotContain(result, r => r.ProductId != 4);
            Assert.Contains(result, r => r.Problem.LastIndexOf("COM", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerKeywordsArgsMultiple()
        {
            // Arrange

            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@Keywords", "COM, RAM")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.DoesNotContain(result, r => r.ProductId != 4);
            Assert.Contains(result, r => r.Problem.LastIndexOf("COM", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("RAM", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}