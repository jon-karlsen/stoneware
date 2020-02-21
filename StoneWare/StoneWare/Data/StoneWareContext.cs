using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Bogus;
using Microsoft.EntityFrameworkCore;
using StoneWare.Models;
using OperatingSystem = StoneWare.Models.OperatingSystem;

namespace StoneWare.Data
{
    public class StoneWareContext : DbContext
    {
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
                entity.HasIndex(e => e.StatusId);

                entity.HasIndex(e => new {e.ProductId, e.OperatingSystemId, e.VersionNumberId});

                entity.Property(e => e.Problem)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Resolution).HasMaxLength(1000);

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeLastUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_Status");

                entity.HasOne(d => d.ProductVersionOs)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => new {d.ProductId, d.OperatingSystemId, d.VersionNumberId})
                    .OnDelete(DeleteBehavior.ClientSetNull)
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

                entity.HasIndex(e => e.OperatingSystemId);

                entity.HasIndex(e => e.VersionNumberId);

                entity.HasOne(d => d.OperatingSystem)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.OperatingSystemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVersionOs_OperatingSystem");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVersionOs_Product");

                entity.HasOne(d => d.VersionNumber)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.VersionNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
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
            modelBuilder.Entity<Status>().HasData(
                new
                {
                    Id = 1,
                    Name = "Outstanding"
                },
                new
                {
                    Id = 2,
                    Name = "Resolved"
                });

            modelBuilder.Entity<Product>().HasData(new Product
                {
                    Id = (int) ProdEnum.DayTraderWannabe,
                    Name = "Day Trader Wannabe"
                },
                new Product
                {
                    Id = (int) ProdEnum.InvestmentOverlord,
                    Name = "Investment Overlord"
                },
                new Product
                {
                    Id = (int) ProdEnum.WorkoutPlanner,
                    Name = "Workout Planner"
                },
                new Product
                {
                    Id = (int) ProdEnum.SocialAnxietyPlanner,
                    Name = "Social Anxiety Planner"
                });

            modelBuilder.Entity<VersionNumber>().HasData(new VersionNumber
                {
                    Id = (int) VerNoEnum.OneZero,
                    Description = "1.0"
                },
                new VersionNumber
                {
                    Id = (int) VerNoEnum.OneOne,
                    Description = "1.1"
                },
                new VersionNumber
                {
                    Id = (int) VerNoEnum.OneTwo,
                    Description = "1.2"
                },
                new VersionNumber
                {
                    Id = (int) VerNoEnum.OneThree,
                    Description = "1.3"
                },
                new VersionNumber
                {
                    Id = (int) VerNoEnum.TwoZero,
                    Description = "2.0"
                },
                new VersionNumber
                {
                    Id = (int) VerNoEnum.TwoOne,
                    Description = "2.1"
                });

            modelBuilder.Entity<OperatingSystem>().HasData(
                new OperatingSystem
                {
                    Id = (int) OSEnum.Linux,
                    Name = "Linux"
                },
                new OperatingSystem
                {
                    Id = (int) OSEnum.MacOS,
                    Name = "MacOS"
                },
                new OperatingSystem
                {
                    Id = (int) OSEnum.Windows,
                    Name = "Windows"
                },
                new OperatingSystem
                {
                    Id = (int) OSEnum.Android,
                    Name = "Android"
                },
                new OperatingSystem
                {
                    Id = (int) OSEnum.iOS,
                    Name = "iOS"
                },
                new OperatingSystem
                {
                    Id = (int) OSEnum.WindowsMobile,
                    Name = "Windows Mobile"
                });

            modelBuilder.Entity<ProductVersionOs>().HasData(
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.Linux
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.Linux
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneTwo,
                    OperatingSystemId = (int) OSEnum.Linux
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneTwo,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneTwo,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneTwo,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneTwo,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneTwo,
                    OperatingSystemId = (int) OSEnum.WindowsMobile
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneThree,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneThree,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneThree,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.DayTraderWannabe,
                    VersionNumberId = (int) VerNoEnum.OneThree,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.TwoZero,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.TwoZero,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.TwoZero,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.TwoOne,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.TwoOne,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.TwoOne,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.InvestmentOverlord,
                    VersionNumberId = (int) VerNoEnum.TwoOne,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.Linux
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.Linux
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.WindowsMobile
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.TwoZero,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.TwoZero,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.TwoZero,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.WorkoutPlanner,
                    VersionNumberId = (int) VerNoEnum.TwoZero,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.iOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneZero,
                    OperatingSystemId = (int) OSEnum.WindowsMobile
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.MacOS
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.Windows
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.Android
                },
                new ProductVersionOs
                {
                    ProductId = (int) ProdEnum.SocialAnxietyPlanner,
                    VersionNumberId = (int) VerNoEnum.OneOne,
                    OperatingSystemId = (int) OSEnum.iOS
                });

            var issues = GenerateTestIssues();

            modelBuilder.Entity<Issue>().HasData(issues);
        }

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private enum OSEnum
        {
            Linux = 1,
            MacOS = 2,
            Windows = 3,
            Android = 4,
            iOS = 5,
            WindowsMobile = 6
        }

        private enum VerNoEnum
        {
            OneZero = 1,
            OneOne = 2,
            OneTwo = 3,
            OneThree = 4,
            TwoZero = 5,
            TwoOne = 6
        }

        private enum ProdEnum
        {
            DayTraderWannabe = 1,
            InvestmentOverlord = 2,
            WorkoutPlanner = 3,
            SocialAnxietyPlanner = 4
        }

        private static IEnumerable<Issue> GenerateTestIssues()
        {
            // Set the randomiser for repeatable data sets
            Randomizer.Seed = new Random(8675309);
            
            var issueId = 1;
            var testIssues = new Faker<Issue>()
                .RuleFor(i => i.Id, f => issueId++)
                .RuleFor(i => i.ProductId, f => f.PickRandom(
                    (int) ProdEnum.DayTraderWannabe,
                    (int) ProdEnum.InvestmentOverlord,
                    (int) ProdEnum.WorkoutPlanner,
                    (int) ProdEnum.SocialAnxietyPlanner)
                )
                .RuleFor(i => i.VersionNumberId, (f, i) => PickVersionNumberId(i, f))
                .RuleFor(i => i.OperatingSystemId, (f, i) => PickOperatingSystemId(i, f))
                .RuleFor(i => i.StatusId, f => f.Random.Number(1, 2))
                .RuleFor(i => i.TimeCreated, f => new DateTime(2020, 02, 16)) // This was previously set to choose from a range of dates, but this breaks testing. Thus single date for all.
                .RuleFor(i => i.TimeLastUpdated, f => f.Date.Recent(2))
                .RuleFor(i => i.Problem, f => f.Hacker.Phrase())
                .RuleFor(i => i.Resolution,
                    (f, i) => i.StatusId == 2 ? f.Hacker.Phrase() : null);

            var issueList = new List<Issue>();

            for (var i = 0; i < 50; i++)
            {
                var testIssue = testIssues.Generate();
                issueList.Add(testIssue);
            }

            return issueList;
        }

        /// <summary>
        /// Picks a "random", valid OperatingSystemId based on which ProductId and
        /// VersionNumberId have previously been selected.
        /// </summary>
        /// <param name="i">Issue object being populated.</param>
        /// <param name="f">Faker instance populating the Issue object.</param>
        /// <returns></returns>
        private static int PickOperatingSystemId(Issue i, Faker f)
        {
            // Based on which ProductId and VersionNumberId that have been selected, not all versions
            // are necessarily applicable. This expression should select a valid Id.
            return i.ProductId switch
            {
                (int) ProdEnum.DayTraderWannabe => i.VersionNumberId switch
                {
                    (int) VerNoEnum.OneZero =>
                    f.PickRandom((int) OSEnum.Linux, (int) OSEnum.Windows),
                    (int) VerNoEnum.OneOne =>
                    f.PickRandom((int) OSEnum.Linux, (int) OSEnum.MacOS, (int) OSEnum.Windows),
                    (int) VerNoEnum.OneTwo =>
                    f.PickRandom((int) OSEnum.Linux, (int) OSEnum.MacOS, (int) OSEnum.Windows, (int) OSEnum.Android,
                        (int) OSEnum.iOS, (int) OSEnum.WindowsMobile),
                    (int) VerNoEnum.OneThree =>
                    f.PickRandom((int) OSEnum.MacOS, (int) OSEnum.Windows, (int) OSEnum.Android, (int) OSEnum.iOS),
                    _ => 0 // Something went wrong -- 0 should force SQL Server to throw
                },
                (int) ProdEnum.InvestmentOverlord => i.VersionNumberId switch
                {
                    (int) VerNoEnum.OneZero =>
                    f.PickRandom((int) OSEnum.MacOS, (int) OSEnum.iOS),
                    (int) VerNoEnum.TwoZero =>
                    f.PickRandom((int) OSEnum.MacOS, (int) OSEnum.Android, (int) OSEnum.iOS),
                    (int) VerNoEnum.TwoOne =>
                    f.PickRandom((int) OSEnum.MacOS, (int) OSEnum.Windows, (int) OSEnum.Android, (int) OSEnum.iOS),
                    _ => 0 // Something went wrong -- 0 should force SQL Server to throw
                },
                (int) ProdEnum.WorkoutPlanner => i.VersionNumberId switch
                {
                    (int) VerNoEnum.OneZero =>
                    f.PickRandom((int) OSEnum.Linux, (int) OSEnum.MacOS),
                    (int) VerNoEnum.OneOne =>
                    f.PickRandom((int) OSEnum.Linux, (int) OSEnum.MacOS, (int) OSEnum.Windows, (int) OSEnum.Android,
                        (int) OSEnum.iOS, (int) OSEnum.WindowsMobile),
                    (int) VerNoEnum.TwoZero =>
                    f.PickRandom((int) OSEnum.MacOS, (int) OSEnum.Windows, (int) OSEnum.Android, (int) OSEnum.iOS),
                    _ => 0 // Something went wrong -- 0 should force SQL Server to throw
                },
                (int) ProdEnum.SocialAnxietyPlanner => i.VersionNumberId switch
                {
                    (int) VerNoEnum.OneZero =>
                    f.PickRandom((int) OSEnum.MacOS, (int) OSEnum.Windows, (int) OSEnum.Android, (int) OSEnum.iOS,
                        (int) OSEnum.WindowsMobile),
                    (int) VerNoEnum.OneOne =>
                    f.PickRandom((int) OSEnum.MacOS, (int) OSEnum.Windows, (int) OSEnum.Android, (int) OSEnum.iOS),
                    _ => 0 // Something went wrong -- 0 should force SQL Server to throw
                },
                _ => 0 // Something went wrong -- 0 should force SQL Server to throw
            };
        }

        /// <summary>
        /// Picks a "random", valid VersionNumberId based on which ProductId has previously
        /// been selected. 
        /// </summary>
        /// <param name="i">Issue object being populated.</param>
        /// <param name="f">Faker instance populating the Issue object.</param>
        /// <returns></returns>
        private static int PickVersionNumberId(Issue i, Faker f)
        {
            // Based on which ProductId has been selected, not all versions
            // are necessarily applicable. This expression should select a valid Id.
            return i.ProductId switch
            {
                (int) ProdEnum.DayTraderWannabe =>
                f.PickRandom((int) VerNoEnum.OneZero, (int) VerNoEnum.OneOne, (int) VerNoEnum.OneTwo,
                    (int) VerNoEnum.OneThree),
                (int) ProdEnum.InvestmentOverlord =>
                f.PickRandom((int) VerNoEnum.OneZero, (int) VerNoEnum.TwoZero, (int) VerNoEnum.TwoOne),
                (int) ProdEnum.WorkoutPlanner =>
                f.PickRandom((int) VerNoEnum.OneZero, (int) VerNoEnum.OneOne, (int) VerNoEnum.TwoZero),
                (int) ProdEnum.SocialAnxietyPlanner =>
                f.PickRandom((int) VerNoEnum.OneZero, (int) VerNoEnum.OneOne),
                _ => 0 // Something went wrong -- 0 should force SQL Server to throw
            };
        }
    }
}