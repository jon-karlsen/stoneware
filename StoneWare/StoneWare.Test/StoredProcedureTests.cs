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
    public class TestIssuesOutstandingSingleProdSingleVerDateRangeKeywordsTests
    {
        private readonly StoneWareContext _context;

        public TestIssuesOutstandingSingleProdSingleVerDateRangeKeywordsTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }


        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerDateRangeKeywordsArgsValid()
        {
            // Arrange

            var result =
                await _context
                    .LoadStoredProc("spIssuesOutstandingSingleProdSingleVerDateRangeKeywords")
                    .WithSqlParam("@ProductId", 1)
                    .WithSqlParam("@VersionNumberId", 1)
                    .WithSqlParam("@OperatingSystemId", 1)
                    .WithSqlParam("@StartDate", "2020-02-15")
                    .WithSqlParam("@EndDate", "2020-02-17")
                    .WithSqlParam("@Keywords", "CSS")
                    .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Single(result);
            Assert.Equal(1, result.First().StatusId);
            Assert.Equal(1, result.First().ProductId);
            Assert.Equal(1, result.First().VersionNumberId);
            Assert.Equal(1, result.First().OperatingSystemId);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.InRange(
                result.First().TimeCreated.Date,
                new DateTime(2020, 02, 15).Date,
                new DateTime(2020, 02, 17).Date
            );
        }
    }
}