using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class IssuesResolvedTests
    {
        private readonly StoneWareContext _context;

        public IssuesResolvedTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }
        
        [Fact]
        public async Task TestIssuesResolved()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolved")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(25, result.Count);
        }
    }
}