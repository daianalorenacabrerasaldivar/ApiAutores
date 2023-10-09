using ApiAutores.Dominio.Entidades;
using ApiAutores.Infraestructura.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiAutores.Api.Controllers
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosControllers : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public LibrosControllers(ApplicationDbContext context)
        {
            this._context = context;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Libro>> Get(int id)
        {
            return await _context.Libros.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpPost]
        public async Task<ActionResult> Post(Libro libro)
        {
            var existeAutor= await _context.Libros.AnyAsync(x=> x.Id == libro.Id);
            if (!existeAutor)
            {
                return BadRequest($"No existe el autor de Id {libro.AutorId}");

            }
            _context.Add(libro);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
