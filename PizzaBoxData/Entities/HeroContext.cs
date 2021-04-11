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

    public virtual DbSet<SuperHero> SuperHeroes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        optionsBuilder.UseSqlServer("Server=tcp:revature-training-james.database.windows.net,1433;Initial Catalog=Hero;Persist Security Info=False;User ID=james.nimmo;Password=Fligh=137;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

      modelBuilder.Entity<SuperHero>(entity =>
      {
        entity.ToTable("SuperHero");

        entity.Property(e => e.Id)
                  .HasColumnType("numeric(18, 0)")
                  .ValueGeneratedOnAdd()
                  .HasColumnName("id");

        entity.Property(e => e.Alias)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.HideOut)
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.RealName)
                  .HasMaxLength(50)
                  .IsUnicode(false);
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
