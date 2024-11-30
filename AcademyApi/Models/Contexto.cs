using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AcademyApi.Models
{
    public class Contexto(DbContextOptions<Contexto> opcoes) : DbContext(opcoes)
    {

        public required DbSet<Usuario> Usuarios { get; set; }
        public required DbSet<Curso> Cursos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
    
    
