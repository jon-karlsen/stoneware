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
    public class IssuesOutstandingSingleProdAllVerKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingSingleProdAllVerKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@Keywords", "CSS")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.DoesNotContain(result, r => r.ProductId != 1);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerKeywordsArgsMultiple()
        {
            // Arrange

            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@Keywords", "HTTP, RAM")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("HTTP", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("RAM", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}