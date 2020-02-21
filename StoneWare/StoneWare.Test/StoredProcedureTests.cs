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
    public class IssueStatusProductVersionTests
    {
        private readonly StoneWareContext _context;

        public IssueStatusProductVersionTests()
        {
            var options = new DbContextOptionsBuilder<StoneWareContext>()
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StoneWare;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            _context = new StoneWareContext(options);
        }

        #region spIssuesOutstanding

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

        #endregion

        #region spIssuesResolved

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

        #endregion

        #region spIssuesOutstandingSingleProdAllVer

        [Theory]
        [InlineData(1, 5)]
        [InlineData(2, 5)]
        [InlineData(3, 8)]
        [InlineData(4, 7)]
        public async Task TestIssuesOutstandingSingleProductAllVersionsProductIdValid(int testId, int expectedAmt)
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", testId)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedAmt, result.Count);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProductAllVersionsProductIdInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", 666)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerProductIdBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", "bad")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
        
        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerProductIdNull()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .WithSqlParam("@ProductId", null)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }
        
        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVer")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        #endregion

        #region spIssuesResolsvedSingleProdAllVer

        [Theory]
        [InlineData(1, 10)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 8)]
        public async Task TestIssuesResolvedSingleProductAllVersionsProductIdValid(int testId, int expectedAmt)
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", testId)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedAmt, result.Count);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProductAllVersionsProductIdInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", 666)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerArgumentOmitted()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }


        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerProductIdBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVer")
                .WithSqlParam("@ProductId", "bad")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        #endregion

        #region spIssuesOutstandingSingleProdSingleVer

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgumentsValid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@VersionNumberId", 1)
                .WithSqlParam("@OperatingSystemId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerArgumentsInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdSingleVer")
                .WithSqlParam("@ProductId", 5)
                .WithSqlParam("@VersionNumberId", 1)
                .WithSqlParam("@OperatingSystemId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgumentsValid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@VersionNumberId", 2)
                .WithSqlParam("@OperatingSystemId", 4)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerArgumentsInvalid()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVer")
                .WithSqlParam("@ProductId", 5)
                .WithSqlParam("@VersionNumberId", 1)
                .WithSqlParam("@OperatingSystemId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        #endregion

        #region spIssuesOutstandingSingleProdAllVerDateRange

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRange()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", new DateTime(2020, 02, 15))
                .WithSqlParam("@EndDate", new DateTime(2020, 02, 17))
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Equal(5, result.Count);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeArgumentsDateNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerDateRangeArgumentsBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", "2020-02-09-09-09")
                .WithSqlParam("@EndDate", "2020-02-11-09-09")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        #endregion

        #region spIssuesOutstandingSingleProdSingleVerDateRange

        [Fact]
        public async Task TestIssuesOutstandingSingleProdSingleVerDateRange()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdSingleVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@VersionNumberId", 1)
                .WithSqlParam("@OperatingSystemId", 1)
                .WithSqlParam("@StartDate", "2020-02-15")
                .WithSqlParam("@EndDate", "2020-02-17")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }

        #endregion

        #region spIssuesResolvedSingleProdAllVerDateRange

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerDateRange()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", "2020-02-15")
                .WithSqlParam("@EndDate", "2020-02-17")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.Equal(10, result.Count);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerDateRangeArgumentsDateNone()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAnyAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerDateRangeArgumentsBad()
        {
            // Arrange

            // Act
            async Task TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerDateRange")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@StartDate", "2020-02-09-09-09")
                .WithSqlParam("@EndDate", "2020-02-11-09-09")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        #endregion

        #region spIssuesResolvedSingleProdSingleVerDateRange

        [Fact]
        public async Task TestIssuesResolvedSingleProdSingleVerDateRange()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdSingleVerDateRange")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@VersionNumberId", 2)
                .WithSqlParam("@OperatingSystemId", 4)
                .WithSqlParam("@StartDate", "2020-02-15")
                .WithSqlParam("@EndDate", "2020-02-17")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
        }

        #endregion

        #region spIssuesOutstandingKeywords

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .WithSqlParam("@Keywords", "CSS")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgsMultiple()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .WithSqlParam("@Keywords", "css, sdd, json")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(6, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("SDD", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("JSON", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesOutstandingKeywordsArgNull()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingKeywords")
                .WithSqlParam("@Keywords", null)
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        
        #endregion

        #region spIssuesResolvedKeywords

        [Fact]
        public async Task TestIssuesResolvedKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedKeywords")
                .WithSqlParam("@Keywords", "PCI")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Contains(result, r => r.Problem.LastIndexOf("PCI", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesResolvedKeywordsArgsMultiple()
        {
            // Arrange

            var result = await _context
                .LoadStoredProc("spIssuesResolvedKeywords")
                .WithSqlParam("@Keywords", "SSL, HDD")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("SSL", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("HDD", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        #endregion

        #region spIssuesOutstandingSingleProdAllVerKeywords

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@Keywords", "CSS")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.DoesNotContain(result, r => r.ProductId != 1);
            Assert.Contains(result, r => r.Problem.LastIndexOf("CSS", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesOutstandingSingleProdAllVerKeywordsArgsMultiple()
        {
            // Arrange

            var result = await _context
                .LoadStoredProc("spIssuesOutstandingSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 1)
                .WithSqlParam("@Keywords", "HTTP, RAM")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, r => r.Problem.LastIndexOf("HTTP", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("RAM", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        #endregion

        #region spIssuesResolvedSingleProdAllVerKeywords

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerKeywordsArgsNone()
        {
            // Arrange

            // Act
            async Task<IEnumerable<IssueStoredProcedureResult>> TestAction() => await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerKeywords")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            await Assert.ThrowsAsync<SqlException>(TestAction);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerKeywordsArgSingle()
        {
            // Arrange

            // Act
            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@Keywords", "COM")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.DoesNotContain(result, r => r.ProductId != 4);
            Assert.Contains(result, r => r.Problem.LastIndexOf("COM", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        [Fact]
        public async Task TestIssuesResolvedSingleProdAllVerKeywordsArgsMultiple()
        {
            // Arrange

            var result = await _context
                .LoadStoredProc("spIssuesResolvedSingleProdAllVerKeywords")
                .WithSqlParam("@ProductId", 4)
                .WithSqlParam("@Keywords", "COM, RAM")
                .ExecuteStoredProc<IssueStoredProcedureResult>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.DoesNotContain(result, r => r.ProductId != 4);
            Assert.Contains(result, r => r.Problem.LastIndexOf("COM", StringComparison.OrdinalIgnoreCase) >= 0);
            Assert.Contains(result, r => r.Problem.LastIndexOf("RAM", StringComparison.OrdinalIgnoreCase) >= 0);
        }

        #endregion

        #region spIssuesOutstandingSingleProdSingleVerKeywords

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
            Assert.ThrowsAsync<SqlException>(TestAction);
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

        #endregion

        #region spIssuesResolvedSingleProdSingleVerKeywords

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

        #endregion

        #region spIssuesOutstandingSingleProdAllVerDateRangeKeywords

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

        #endregion

        #region spIssuesResolvedSingleProdAllVerDateRangeKeywords

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

        #endregion
        
        #region spIssuesOutstandingSingleProdSingleVerDateRangeKeywords 
        
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
        
        #endregion
        
        #region  
        
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
        
        #endregion
    }
}