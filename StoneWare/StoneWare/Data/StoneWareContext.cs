using Microsoft.EntityFrameworkCore;
using StoneWare.Models;

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
        public virtual DbSet<Models.OperatingSystem> OperatingSystem { get; set; }
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_Status");

                entity.HasOne(d => d.ProductVersionOs)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => new {d.ProductId, d.OperatingSystemId, d.VersionNumberId})
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_ProductVersionOs");
            });

            modelBuilder.Entity<Models.OperatingSystem>(entity =>
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
            modelBuilder.Entity<OperatingSystem>()
                .HasData(
                    new OperatingSystem
                    {
                        Id = 1,
                        Name = "Linux"
                    },
                    new OperatingSystem
                    {
                        Id = 2,
                        Name = "MacOS"
                    },
                    new OperatingSystem
                    {
                        Id = 3,
                        Name = "Windows"
                    },
                    new OperatingSystem
                    {
                        Id = 4,
                        Name = "Android"
                    },
                    new OperatingSystem
                    {
                        Id = 5,
                        Name = "iOS"
                    },
                    new OperatingSystem
                    {
                        Id = 6,
                        Name = "Windows Mobile"
                    }
                );

            modelBuilder.Entity<VersionNumber>()
                .HasData(
                    new VersionNumber
                    {
                        Id = 1,
                        Description = "1.0"
                    },
                    new VersionNumber
                    {
                        Id = 2,
                        Description = "1.1"
                    },
                    new VersionNumber
                    {
                        Id = 3,
                        Description = "1.2"
                    },
                    new VersionNumber
                    {
                        Id = 4,
                        Description = "1.3"
                    },
                    new VersionNumber
                    {
                        Id = 5,
                        Description = "2.0"
                    },
                    new VersionNumber
                    {
                        Id = 6,
                        Description = "2.1"
                    }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Day Trader Wannabe"
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Investment Overlord"
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Workout Planner"
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Social Anxiety Planner"
                    }
                );

            modelBuilder.Entity<Status>()
                .HasData(
                    new Status
                    {
                        Id = 1,
                        Name = "Open"
                    },
                    new Status
                    {
                        Id = 2,
                        Name = "Resolved"
                    }
                );
        }
    }
}