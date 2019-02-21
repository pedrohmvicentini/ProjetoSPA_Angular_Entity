using System.Data.Entity;

namespace ProjetoSPA_Angular_Entity.Models
{
    public class FilmeDb : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
    }
}