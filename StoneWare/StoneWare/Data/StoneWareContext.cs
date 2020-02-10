using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using StoneWare.Models;
using OperatingSystem = StoneWare.Models.OperatingSystem;

namespace StoneWare.Data
{
    public class StoneWareContext : DbContext
    {
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private enum OperatingSystemEnum
        {
            Linux = 1,
            MacOS = 2,
            Windows = 3,
            Android = 4,
            iOS = 5,
            WindowsMobile = 6
        }

        private enum VersionNumberEnum
        {
            OneZero = 1,
            OneOne = 2,
            OneTwo = 3,
            OneThree = 4,
            TwoZero = 5,
            TwoOne = 6
        }

        private enum ProductEnum
        {
            DayTraderWannabe = 1,
            InvestmentOverlord = 2,
            WorkoutPlanner = 3,
            SocialAnxietyPlanner = 4
        }

        public StoneWareContext()
        {
        }

        public StoneWareContext(DbContextOptions<StoneWareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<OperatingSystem> OperatingSystem { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductVersionOs> ProductVersionOs { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<VersionNumber> VersionNumber { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(
                    "Data Source=Lenovo-310\\SQLEXPRESS;Initial Catalog=StoneWare;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issue>(entity =>
            {
                entity.Property(e => e.Problem)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Resolution).HasMaxLength(1000);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeLastUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.StatusId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_Status");

                entity.HasOne(d => d.ProductVersionOs)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => new {d.ProductId, d.OperatingSystemId, d.VersionNumberId})
//                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_ProductVersionOs");
            });

            modelBuilder.Entity<OperatingSystem>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ProductVersionOs>(entity =>
            {
                entity.HasKey(e => new {e.ProductId, e.OperatingSystemId, e.VersionNumberId});

                entity.Property(e => e.VersionNumberId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.OperatingSystem)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.OperatingSystemId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVersionOs_OperatingSystem");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.ProductId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVersionOs_Product");

                entity.HasOne(d => d.VersionNumber)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.VersionNumberId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVersionOs_VersionNumber");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VersionNumber>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

//            modelBuilder.Entity<Issue>()
//                .HasData(
//                    new Issue
//                    {
//                        Id = 1,
//                        StatusId = 1,
//                        ProductId = 4,
//                        VersionNumberId = 2,
//                        OperatingSystemId = 5,
//                        TimeCreated = DateTime.Now,
//                        TimeLastUpdated = DateTime.Now, 
//                        Problem = "This is a test",
//                        Resolution = "This is also a test"
//                    }
//                );

//            var issueList = PopulateTestIssues();
//
//            modelBuilder.Entity<Issue>().HasData(issueList);
        }

        
    }
}