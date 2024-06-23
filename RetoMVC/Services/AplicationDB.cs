using Microsoft.EntityFrameworkCore;
using RetoMVC.Models;
using System.Reflection.Metadata;

namespace RetoMVC.Services
{

    public class AplicationDB : DbContext
    {
        public AplicationDB(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Empleados)
                .WithOne(e => e.Departamento)
                .HasForeignKey(e => e.DepartamentoId)
                .IsRequired();
        }
    }
}