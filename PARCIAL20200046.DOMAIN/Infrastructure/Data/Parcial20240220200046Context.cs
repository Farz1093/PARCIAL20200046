using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PARCIAL20200046.DOMAIN.Core.Entities;

namespace PARCIAL20200046.DOMAIN.Infrastructure.Data;

public partial class Parcial20240220200046Context : DbContext
{
    public Parcial20240220200046Context()
    {
    }

    public Parcial20240220200046Context(DbContextOptions<Parcial20240220200046Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Mechanic> Mechanic { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2300730;Database=Parcial20240220200046;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mechanic>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
