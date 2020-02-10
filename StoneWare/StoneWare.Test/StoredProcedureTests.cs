using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoneWare.Data;
using StoneWare.Models;
using Xunit;

namespace StoneWare.Test
{
    public class StoredProcedureTests
    {
        private readonly StoneWareContext _context;

        public StoredProcedureTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer("Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestSpIssueAll_ProductAll()
        {
            // Arrange

            // Act
            var result =
                await _context.LoadStoredProc("SpIssueAll_ProductAll")
                    .ExecuteStoredProc<Issue>();
                
            // Assert
            Assert.NotNull(result);
            Assert.Equal(36, result.Count);
        }
    }
}