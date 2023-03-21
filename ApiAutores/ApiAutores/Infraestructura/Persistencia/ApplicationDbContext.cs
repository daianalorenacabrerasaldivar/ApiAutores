using Microsoft.EntityFrameworkCore;
using WebApiAutores.Dominio.Entidades;

namespace ApiAutores.Infraestructura.Persistencia
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }

    }
}
