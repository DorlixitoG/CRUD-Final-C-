using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUDFINAL.Models;

public partial class SoftShirtContext : DbContext
{
    public SoftShirtContext()
    {
    }

    public SoftShirtContext(DbContextOptions<SoftShirtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compra> Compras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-QEBBRAK\\SQLEXPRESS;\nTrustServerCertificate=Yes;\n database=Soft_Shirt; integrated security=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Compras__3214EC07C4EE42A5");

            entity.Property(e => e.IdProveedor).HasColumnName("Id_proveedor");
            entity.Property(e => e.Iva).HasColumnName("IVA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
