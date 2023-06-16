using WebApiAutores.Dominio.Entidades;

namespace ApiAutores.Dominio.Entidades
{
    public class Libro { 
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
