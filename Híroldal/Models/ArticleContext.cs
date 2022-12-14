using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Híroldal.Models;

public partial class ArticleContext : DbContext
{
    public ArticleContext()
    {
    }

    public ArticleContext(DbContextOptions<ArticleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Articles> Articles { get; set; }

    public virtual DbSet<Columns> Columns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ogkiszolgalo.database.windows.net;Initial Catalog=CikkDB;Persist Security Info=True;User ID=q4gpvc;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Articles>(entity =>
        {
            entity.HasKey(e => e.ArticleId).HasName("PK__ARTICLES__9C6270E82316CCFC");

            entity.ToTable("ARTICLES");

            entity.HasOne(d => d.Column).WithMany(p => p.Articles)
                .HasForeignKey(d => d.ColumnId)
                .HasConstraintName("FK__ARTICLES__Column__5EBF139D");
        });

        modelBuilder.Entity<Columns>(entity =>
        {
            entity.HasKey(e => e.ColumnId).HasName("PK__COLUMNS__1AA1420F03E8928D");

            entity.ToTable("COLUMNS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
