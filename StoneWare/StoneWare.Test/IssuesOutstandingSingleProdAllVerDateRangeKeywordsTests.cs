using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesOutstandingSingleProdAllVerDateRangeKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingSingleProdAllVerDateRangeKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeKeywordsArgsValid()
        {
            // Arrange

            // Act
            var result =
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRangeKeywords")
                    .WithSqlParam("@ProductId", 2)
                    .WithSqlParam("@StartDate", "2020-02-15")
                    .WithSqlParam("@EndDate", "2020-02-17")
                    .WithSqlParam("@Keywords", "ADP, THX, JSON")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(1, result.First().StatusId);
            Assert.Equal(2, result.First().ProductId);
            Assert.Contains(result, r => r.Problem.LastIndexOf("ADP", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("THX", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("JSON", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.InRange(
                result.First().TimeCreated.Date,
                new DateTime(2020, 02, 15).Date,
                new DateTime(2020, 02, 17).Date
            );
        }
    }
}