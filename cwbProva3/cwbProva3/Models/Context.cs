using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cwbProva3.Models
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

    }
}