using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PizzaBoxData.Entities
{
  public partial class HeroContext : DbContext
  {
    public HeroContext()
    {
    }

    public HeroContext(DbContextOptions<HeroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CrustInfo> CrustInfos { get; set; }
    public virtual DbSet<MyOrder> MyOrders { get; set; }
    public virtual DbSet<OrderInfo2> OrderInfo2s { get; set; }
    public virtual DbSet<OrderInfo3> OrderInfo3s { get; set; }
    public virtual DbSet<SizeInfo> SizeInfos { get; set; }
    public virtual DbSet<ToppingInfo> ToppingInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {

      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

      modelBuilder.Entity<CrustInfo>(entity =>
      {
        entity.HasKey(e => e.CrustId);

        entity.ToTable("CrustInfo");

        entity.Property(e => e.CrustName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.CrustPrice).HasColumnType("decimal(7, 2)");
      });


      modelBuilder.Entity<MyOrder>(entity =>
      {
        entity.HasNoKey();

        entity.ToView("MyOrder");

        entity.Property(e => e.CrustName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.CrustPrice).HasColumnType("decimal(7, 2)");

        entity.Property(e => e.OrderTime).HasColumnType("datetime");

        entity.Property(e => e.PizzaName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.SizeName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.SizePrice).HasColumnType("decimal(7, 2)");

        entity.Property(e => e.StoreName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.UserName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);
      });

      modelBuilder.Entity<OrderInfo2>(entity =>
      {
        entity.ToTable("OrderInfo2");

        entity.Property(e => e.Id).ValueGeneratedNever();

        entity.Property(e => e.PizzaName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.StroreName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.UserName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.HasOne(d => d.CrustTypeNavigation)
                  .WithMany(p => p.OrderInfo2s)
                  .HasForeignKey(d => d.CrustType)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__OrderInfo__Crust__0F624AF8");

        entity.HasOne(d => d.SizeTypeNavigation)
                  .WithMany(p => p.OrderInfo2s)
                  .HasForeignKey(d => d.SizeType)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__OrderInfo__SizeT__10566F31");

        entity.HasOne(d => d.Top1Navigation)
                  .WithMany(p => p.OrderInfo2Top1Navigations)
                  .HasForeignKey(d => d.Top1)
                  .HasConstraintName("FK__OrderInfo2__Top1__114A936A");

        entity.HasOne(d => d.Top2Navigation)
                  .WithMany(p => p.OrderInfo2Top2Navigations)
                  .HasForeignKey(d => d.Top2)
                  .HasConstraintName("FK__OrderInfo2__Top2__123EB7A3");

        entity.HasOne(d => d.Top3Navigation)
                  .WithMany(p => p.OrderInfo2Top3Navigations)
                  .HasForeignKey(d => d.Top3)
                  .HasConstraintName("FK__OrderInfo2__Top3__1332DBDC");

        entity.HasOne(d => d.Top4Navigation)
                  .WithMany(p => p.OrderInfo2Top4Navigations)
                  .HasForeignKey(d => d.Top4)
                  .HasConstraintName("FK__OrderInfo2__Top4__14270015");

        entity.HasOne(d => d.Top5Navigation)
                  .WithMany(p => p.OrderInfo2Top5Navigations)
                  .HasForeignKey(d => d.Top5)
                  .HasConstraintName("FK__OrderInfo2__Top5__151B244E");
      });

      modelBuilder.Entity<OrderInfo3>(entity =>
      {
        entity.ToTable("OrderInfo3");

        entity.Property(e => e.OrderTime).HasColumnType("datetime");

        entity.Property(e => e.PizzaName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.StoreName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.UserName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.HasOne(d => d.CrustTypeNavigation)
                  .WithMany(p => p.OrderInfo3s)
                  .HasForeignKey(d => d.CrustType)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__OrderInfo__Crust__1BC821DD");

        entity.HasOne(d => d.SizeTypeNavigation)
                  .WithMany(p => p.OrderInfo3s)
                  .HasForeignKey(d => d.SizeType)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__OrderInfo__SizeT__1CBC4616");
      });

      modelBuilder.Entity<SizeInfo>(entity =>
      {
        entity.HasKey(e => e.SizeId)
                  .HasName("PK_Size");

        entity.ToTable("SizeInfo");

        entity.Property(e => e.SizeName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.SizePrice).HasColumnType("decimal(7, 2)");
      });


      modelBuilder.Entity<ToppingInfo>(entity =>
      {
        entity.HasKey(e => e.ToppingId);

        entity.ToTable("ToppingInfo");

        entity.Property(e => e.ToppingName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
