using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class TestIssuesResolvedSingleProdSingleVerDateRangeKeywordsTests
    {
        private readonly StoneWareContext _context;

        public TestIssuesResolvedSingleProdSingleVerDateRangeKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerDateRangeKeywordsArgsValid()
        {
            // Arrange
            var result =
                await _context
                    .LoadStoredProc("spIssuesResolvedSingleProdSingleVerDateRangeKeywords")
                    .WithSqlParam("@ProductId", 4)
                    .WithSqlParam("@VersionNumberId", 2)
                    .WithSqlParam("@OperatingSystemId", 3)
                    .WithSqlParam("@StartDate", "2020-02-15")
                    .WithSqlParam("@EndDate", "2020-02-17")
                    .WithSqlParam("@Keywords", "COM, matrix")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(2, result.First().StatusId);
            Assert.Equal(4, result.First().ProductId);
            Assert.Equal(2, result.First().VersionNumberId);
            Assert.Equal(3, result.First().OperatingSystemId);
            Assert.Contains(result, r => r.Problem.LastIndexOf("COM", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                         r.Problem.LastIndexOf("matrix", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.InRange(
                result.First().TimeCreated.Date,
                new DateTime(2020, 02, 15).Date,
                new DateTime(2020, 02, 17).Date
            );
        }
    }
}