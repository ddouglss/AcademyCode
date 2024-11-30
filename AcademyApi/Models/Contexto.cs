using Microsoft.EntityFrameworkCore;

namespace AcademyApi.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
        }

        public required DbSet<Usuario> Usuarios { get; set; }
        public required DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defina suas configurações específicas do modelo aqui, se necessário
        }
    }
}
