using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; } 
        public required string Nome { get; set; }
        public required string Sobrenome { get; set; }
        public required string Telefone { get; set; }      
        public required string Email { get; set; }
        public required string Cidade { get; set; }
        public required string Senha { get; set; }
        public required string AreaCurso { get; set; } 
        
    }
}