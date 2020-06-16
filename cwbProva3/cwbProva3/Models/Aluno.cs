using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cwbProva3.Models
{
    public class Aluno
    {
        [Key]
        
        public string Nome { get; set; }
        public String Sexo { get; set; }
       
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Curso { get; set; }
        public int AnoInicio { get; set; }
        public int Ra { get; set; }
        public int DataNascimento { get; set; }
    }
}