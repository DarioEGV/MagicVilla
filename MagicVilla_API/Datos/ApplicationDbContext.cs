using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id=1,
                    Nombre="Tokio",
                    Detalle="moderna cuidad",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=50,
                    Tarifa=200,
                    Amenidad="",
                    FechaCreacion=DateTime.Now,
                    FechaActualizacion=DateTime.Now
                },
                new Villa()
                                {
                                    Id = 2,
                                    Nombre = "Kioto",
                                    Detalle = "cuidad 2",
                                    ImagenUrl = "",
                                    Ocupantes = 5,
                                    MetrosCuadrados = 40,
                                    Tarifa = 150,
                                    Amenidad = "",
                                    FechaCreacion = DateTime.Now,
                                    FechaActualizacion = DateTime.Now
                                }
                );
        }
    }
}
