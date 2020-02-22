using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesOutstandingTests
    {
        private readonly StoneWareContext _context;

        public IssuesOutstandingTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }
        
        [Fact]
        public async Task TestIssuesOutstanding()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstanding")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(25, result.Count);
        }
    }
}