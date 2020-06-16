using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cwbProva2.Models
{
    public class Trabalhador
    {
        [Key]
        public String Nome { get; set; }
        public String Sexo { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int DataNascimento { get; set; }
        public int CarteraTrabalho { get; set; }
        public int Fonefixo { get; set; }
        public int FoneCelular { get; set; }
        
    }
}