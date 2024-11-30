using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AcademyApi.Models
{
    public class Curso
    {
         [Key]
    public int CursoId { get; set; } // PK

    public required string Nome { get; set; }
    public required string Area { get; set; } // Ex.: Front-end, Back-end
    }
}