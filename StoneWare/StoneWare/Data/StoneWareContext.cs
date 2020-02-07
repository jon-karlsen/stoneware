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
//            modelBuilder.Entity<OperatingSystem>()
//                .HasData(
//                    new OperatingSystem
//                    {
//                        Id = (int) OperatingSystemEnum.Linux,
//                        Name = "Linux"
//                    },
//                    new OperatingSystem
//                    {
//                        Id = (int) OperatingSystemEnum.MacOS,
//                        Name = "MacOS"
//                    },
//                    new OperatingSystem
//                    {
//                        Id = (int) OperatingSystemEnum.Windows,
//                        Name = "Windows"
//                    },
//                    new OperatingSystem
//                    {
//                        Id = (int) OperatingSystemEnum.Android,
//                        Name = "Android"
//                    },
//                    new OperatingSystem
//                    {
//                        Id = (int) OperatingSystemEnum.iOS,
//                        Name = "iOS"
//                    },
//                    new OperatingSystem
//                    {
//                        Id = (int) OperatingSystemEnum.WindowsMobile,
//                        Name = "Windows Mobile"
//                    }
//                );

//            modelBuilder.Entity<VersionNumber>()
//                .HasData(
//                    new VersionNumber
//                    {
//                        Id = (int) VersionNumberEnum.OneZero,
//                        Description = "1.0"
//                    },
//                    new VersionNumber
//                    {
//                        Id = (int) VersionNumberEnum.OneOne,
//                        Description = "1.1"
//                    },
//                    new VersionNumber
//                    {
//                        Id = (int) VersionNumberEnum.OneTwo,
//                        Description = "1.2"
//                    },
//                    new VersionNumber
//                    {
//                        Id = (int) VersionNumberEnum.OneThree,
//                        Description = "1.3"
//                    },
//                    new VersionNumber
//                    {
//                        Id = (int) VersionNumberEnum.TwoZero,
//                        Description = "2.0"
//                    },
//                    new VersionNumber
//                    {
//                        Id = (int) VersionNumberEnum.TwoOne,
//                        Description = "2.1"
//                    }
//                );

//            modelBuilder.Entity<Product>()
//                .HasData(
//                    new Product
//                    {
//                        Id = (int) ProductEnum.DayTraderWannabe,
//                        Name = "Day Trader Wannabe"
//                    },
//                    new Product
//                    {
//                        Id = (int) ProductEnum.InvestmentOverlord,
//                        Name = "Investment Overlord"
//                    },
//                    new Product
//                    {
//                        Id = (int) ProductEnum.WorkoutPlanner,
//                        Name = "Workout Planner"
//                    },
//                    new Product
//                    {
//                        Id = (int) ProductEnum.SocialAnxietyPlanner,
//                        Name = "Social Anxiety Planner"
//                    }
//                );

//            modelBuilder.Entity<Status>()
//                .HasData(
//                    new Status
//                    {
//                        Id = 1,
//                        Name = "Open"
//                    },
//                    new Status
//                    {
//                        Id = 2,
//                        Name = "Resolved"
//                    }
//                );

//            modelBuilder.Entity<ProductVersionOs>()
//                .HasData(
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Linux
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Linux
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
//                        OperatingSystemId = (int) OperatingSystemEnum.Linux
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
//                        OperatingSystemId = (int) OperatingSystemEnum.WindowsMobile
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneThree,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneThree,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneThree,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.DayTraderWannabe,
//                        VersionNumberId = (int) VersionNumberEnum.OneThree,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.InvestmentOverlord,
//                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Linux
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Linux
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.WindowsMobile
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.WorkoutPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneZero,
//                        OperatingSystemId = (int) OperatingSystemEnum.WindowsMobile
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Windows
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.Android
//                    },
//                    new ProductVersionOs
//                    {
//                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
//                        VersionNumberId = (int) VersionNumberEnum.OneOne,
//                        OperatingSystemId = (int) OperatingSystemEnum.iOS
//                    }
//                );

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

        // TODO: ProductVersionOs seed data is likely invalid.
        // TODO: make Product, Version, Os enums and triple-check

        private static IEnumerable<Issue> PopulateTestIssues()
        {
            // Set the randomiser for repeatable data sets
            Randomizer.Seed = new Random(8675309);

            var issueId = 1;
            var testIssues = new Faker<Issue>()
                //.StrictMode(true)
                .RuleFor(i => i.Id, f => issueId++)
                .RuleFor(i => i.ProductId, f => f.PickRandom(
                        (int) ProductEnum.DayTraderWannabe,
                        (int) ProductEnum.InvestmentOverlord,
                        (int) ProductEnum.WorkoutPlanner,
                        (int) ProductEnum.SocialAnxietyPlanner)
                )
                .RuleFor(i => i.VersionNumberId, (f, i) => PickVersionNumberId(i, f))
                .RuleFor(i => i.OperatingSystemId, (f, i) => PickOperatingSystemId(i, f))
                .RuleFor(i => i.StatusId, f => f.Random.Number(1, 2))
                .RuleFor(i => i.TimeCreated, f => f.Date.Recent(7))
                .RuleFor(i => i.TimeLastUpdated, f => f.Date.Recent(2))
                .RuleFor(i => i.Problem, f => f.Lorem.Sentence(100))
                .RuleFor(i => i.Resolution,
                    (f, i) => i.StatusId == 2 ? f.Lorem.Sentence(100) : null);

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
                (int) ProductEnum.DayTraderWannabe => i.VersionNumberId switch
                {
                    (int) VersionNumberEnum.OneZero => f.PickRandom((int) OperatingSystemEnum.Linux, (int) OperatingSystemEnum.Windows ),
                    (int) VersionNumberEnum.OneOne => f.PickRandom((int) OperatingSystemEnum.Linux, (int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows),
                    (int) VersionNumberEnum.OneTwo => f.PickRandom((int) OperatingSystemEnum.Linux, (int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS, (int) OperatingSystemEnum.WindowsMobile),
                    (int) VersionNumberEnum.OneThree => f.PickRandom((int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS)
                },
                (int) ProductEnum.InvestmentOverlord => i.VersionNumberId switch
                {
                    (int) VersionNumberEnum.OneZero => f.PickRandom((int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.iOS),
                    (int) VersionNumberEnum.TwoZero => f.PickRandom((int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS),
                    (int) VersionNumberEnum.TwoOne => f.PickRandom((int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS)
                },
                (int) ProductEnum.WorkoutPlanner => i.VersionNumberId switch
                {
                    (int) VersionNumberEnum.OneZero => f.PickRandom((int) OperatingSystemEnum.Linux, (int) OperatingSystemEnum.MacOS),
                    (int) VersionNumberEnum.OneOne => f.PickRandom((int) OperatingSystemEnum.Linux, (int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS, (int) OperatingSystemEnum.WindowsMobile),
                    (int) VersionNumberEnum.TwoZero => f.PickRandom((int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS)
                },
                (int) ProductEnum.SocialAnxietyPlanner => i.VersionNumberId switch
                {
                    (int) VersionNumberEnum.OneZero => f.PickRandom((int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS, (int) OperatingSystemEnum.WindowsMobile),
                    (int) VersionNumberEnum.OneOne => f.PickRandom((int) OperatingSystemEnum.MacOS, (int) OperatingSystemEnum.Windows, (int) OperatingSystemEnum.Android, (int) OperatingSystemEnum.iOS)
                },
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
                (int) ProductEnum.DayTraderWannabe => f.PickRandom((int) VersionNumberEnum.OneZero, (int) VersionNumberEnum.OneOne, (int) VersionNumberEnum.OneTwo, (int) VersionNumberEnum.OneThree),
                (int) ProductEnum.InvestmentOverlord => f.PickRandom((int) VersionNumberEnum.OneZero, (int) VersionNumberEnum.TwoZero, (int) VersionNumberEnum.TwoOne),
                (int) ProductEnum.WorkoutPlanner => f.PickRandom((int) VersionNumberEnum.OneZero, (int) VersionNumberEnum.OneOne, (int) VersionNumberEnum.TwoZero),
                (int) ProductEnum.SocialAnxietyPlanner => f.PickRandom((int) VersionNumberEnum.OneZero, (int) VersionNumberEnum.OneOne),
                _ => 0
            };
        }
    }
}