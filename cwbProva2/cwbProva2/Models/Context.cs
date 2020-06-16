using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cwbProva2.Models
{
    public class Context : DbContext
    {
        public DbSet<Trabalhador> Trabalhadores { get; set; }
    }
}