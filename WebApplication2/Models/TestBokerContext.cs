using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class TestBokerContext : DbContext
    {
        //public TestBokerContext()
        //{
        //}

        public TestBokerContext(DbContextOptions<TestBokerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<ContentList> ContentList { get; set; }
        public virtual DbSet<Exhibition> Exhibition { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LoginLog> LoginLog { get; set; }
        public virtual DbSet<Md5Test> Md5Test { get; set; }
        public virtual DbSet<Md5Test1> Md5Test1 { get; set; }
        public virtual DbSet<Md5Test10> Md5Test10 { get; set; }
        public virtual DbSet<Md5Test2> Md5Test2 { get; set; }
        public virtual DbSet<Md5Test3> Md5Test3 { get; set; }
        public virtual DbSet<Md5Test4> Md5Test4 { get; set; }
        public virtual DbSet<Md5Test5> Md5Test5 { get; set; }
        public virtual DbSet<Md5Test6> Md5Test6 { get; set; }
        public virtual DbSet<Md5Test7> Md5Test7 { get; set; }
        public virtual DbSet<Md5Test8> Md5Test8 { get; set; }
        public virtual DbSet<Md5Test9> Md5Test9 { get; set; }
        public virtual DbSet<Md5TestUser> Md5TestUser { get; set; }
        public virtual DbSet<VMd5test> VMd5test { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=.;Database=TestBoker;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    }
        //}

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ContentList>(entity =>
            {
                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastTime).HasColumnType("datetime");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Exhibition>(entity =>
            {
                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Src).IsRequired();

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoginLog>(entity =>
            {
                entity.Property(e => e.Chrome).IsRequired();

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Md5Test>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.Key, e.Value, e.Id })
                    .HasName("Index_Md5Test_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<Md5Test1>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.Key, e.Value, e.Id })
                    .HasName("Index_Md5Test_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<Md5Test10>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Md5Test2>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.Key, e.Value, e.Id })
                    .HasName("Index_Md5Test_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<Md5Test3>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.Key, e.Value, e.Id })
                    .HasName("Index_Md5Test_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<Md5Test4>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Md5Test5>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Md5Test6>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Md5Test7>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Md5Test8>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Md5Test9>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Md5TestUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VMd5test>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_MD5Test");

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }
        #endregion

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
