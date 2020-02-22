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
    public class IssuesResolvedSingleProdSingleVerKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedSingleProdSingleVerKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() =>
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdSingleVerKeywords")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerKeywordsArgsValid()
        {
            // Arrange

            // Act
            var result =
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdSingleVerKeywords")
                    .WithSqlParam("@ProductId", 4)
                    .WithSqlParam("@VersionNumberId", 2)
                    .WithSqlParam("@OperatingSystemId", 3)
                    .WithSqlParam("@Keywords", "COM")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Single(result);
            Assert.Equal(2, result.First().StatusId);
            Assert.Equal(4, result.First().ProductId);
            Assert.Equal(2, result.First().VersionNumberId);
            Assert.Equal(3, result.First().OperatingSystemId);
            Assert.Contains(result, r => r.Problem.LastIndexOf("COM", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}