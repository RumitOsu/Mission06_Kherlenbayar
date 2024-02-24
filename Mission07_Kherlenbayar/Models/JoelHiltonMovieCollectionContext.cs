﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission07_Kherlenbayar.Models;

public partial class JoelHiltonMovieCollectionContext : DbContext
{
    public JoelHiltonMovieCollectionContext()
    {
    }

    public JoelHiltonMovieCollectionContext(DbContextOptions<JoelHiltonMovieCollectionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("DataSource=JoelHiltonMovieCollection.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.Movies).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
