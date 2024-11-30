using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApi.Models
{
    public class LoginRequest
    {
         public required string Email { get; set; }
        public required string Senha { get; set; } // Adicione esta propriedade
    }
}