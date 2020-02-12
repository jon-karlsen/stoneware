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
    public class IssueStatusTests
    {
        private readonly StoneWareContext _context;

        public IssueStatusTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        [Fact]
        public async Task TestIssueStatusArgumentNone()
        {
            // Arrange

            // Act
            var result =
                await _context.LoadStoredProc("spIssueStatus")
                    .ExecuteStoredProc<IssueDto>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(50, result.Count);
        }

        [Fact]
        public async Task TestIssueStatusUnresolved()
        {
            // Arrange

            // Act
            var result =
                await _context.LoadStoredProc("spIssueQuery")
                    .WithSqlParam("@StatusId", 2)
                    .ExecuteStoredProc<IssueDto>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(36, result.Count);
            Assert.Null(result.First().Resolution);
            Assert.Equal(2, result.First().StatusId);
        }

        [Fact]
        public async Task TestIssueStatusResolved()
        {
            // Arrange

            // Act
            var result =
                await _context.LoadStoredProc("spIssueQuery")
                    .WithSqlParam("@StatusId", 1)
                    .ExecuteStoredProc<IssueDto>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(14, result.Count);
            Assert.NotNull(result.First().Resolution);
            Assert.Equal(1, result.First().StatusId);
        }

        [Fact]
        public async Task TestIssueStatusIdInvalid()
        {
            // Arrange

            // Act
            var result =
                await _context.LoadStoredProc("spIssueQuery")
                    .WithSqlParam("@StatusId", 3)
                    .ExecuteStoredProc<IssueDto>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssueStatusIdBad()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueDto>> TestAction() => 
                await _context.LoadStoredProc("spIssueQuery")
                    .WithSqlParam("@StatusId", "bad")
                    .ExecuteStoredProc<IssueDto>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

    }
}