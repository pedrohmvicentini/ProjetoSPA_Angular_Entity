namespace ProjetoSPA_Angular_Entity.Migrations
{
    using ProjetoSPA_Angular_Entity.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmeDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FilmeDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            context.Filmes.AddOrUpdate(
              p => p.Titulo,
              new Filme { Titulo = "Into the wild", AnoLancamento = 2006, Duracao = 170 },
              new Filme { Titulo = "Space Jam", AnoLancamento = 1996, Duracao = 121 },
              new Filme { Titulo = "The Hangout", AnoLancamento = 2012, Duracao = 130 },
              new Filme { Titulo = "Identidade Bourne", AnoLancamento = 2002, Duracao = 110 },
              new Filme { Titulo = "Jungle", AnoLancamento = 2016, Duracao = 135 }
            );
        }
    }
}
