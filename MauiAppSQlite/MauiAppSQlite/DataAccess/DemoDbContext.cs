
using MauiAppSQlite.Modelos;
using MauiAppSQlite.Utilidades;
using Microsoft.EntityFrameworkCore;

namespace MauiAppSQlite.DataAccess
{
    public class DemoDbContext : DbContext
    {

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDb = $"Filename={ConexionDb.DevolverRuta("demo.db")}";
            optionsBuilder.UseSqlite(conexionDb);
        }
    }
}
