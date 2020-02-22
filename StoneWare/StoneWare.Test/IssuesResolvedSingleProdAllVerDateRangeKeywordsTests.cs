using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesResolvedSingleProdAllVerDateRangeKeywordsTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedSingleProdAllVerDateRangeKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerDateRangeKeywordsArgsValid()
        {
            // Arrange

            var result =
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdAllVerDateRangeKeywords")
                    .WithSqlParam("@ProductId", 4)
                    .WithSqlParam("@StartDate", "2020-02-15")
                    .WithSqlParam("@EndDate", "2020-02-17")
                    .WithSqlParam("@Keywords", "COM")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Single(result);
            Assert.Equal(2, result.First().StatusId);
            Assert.Equal(4, result.First().ProductId);
            Assert.Contains(result, r => r.Problem.LastIndexOf("COM", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.InRange(
                result.First().TimeCreated.Date,
                new DateTime(2020, 02, 15).Date,
                new DateTime(2020, 02, 17).Date
            );
        }
    }
}