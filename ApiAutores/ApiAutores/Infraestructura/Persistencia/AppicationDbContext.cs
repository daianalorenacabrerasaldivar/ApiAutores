using Microsoft.EntityFrameworkCore;
using WebApiAutores.Dominio.Entidades;

namespace ApiAutores.Infraestructura.Persistencia
{
    public class AppicationDbContext : DbContext
    {
        public AppicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }

    }
}
