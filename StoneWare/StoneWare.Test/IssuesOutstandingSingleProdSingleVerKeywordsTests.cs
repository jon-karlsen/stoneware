using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesOutstandingSingleProdSingleVerKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingSingleProdSingleVerKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdSingleVerKeywords")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerKeywordsArgsValid()
        {
            // Arrange

            // Act
            var result =
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdSingleVerKeywords")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", 1)
                    .WithSqlParam("@OperatingSystemId", 1)
                    .WithSqlParam("@Keywords", "CSS")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Single(result);
            Assert.Equal(1, result.First().StatusId);
            Assert.Equal(1, result.First().ProductId);
            Assert.Equal(1, result.First().VersionNumberId);
            Assert.Equal(1, result.First().OperatingSystemId);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}