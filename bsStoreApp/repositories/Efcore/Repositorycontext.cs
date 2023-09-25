using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using entities.Models;
using repositories.Efcore.config;

namespace repositories.Efcore
{
    public class Repositorycontext:DbContext
    {

        public Repositorycontext(DbContextOptions<Repositorycontext> options)
          : base(options)
        {
        }
        public DbSet<Book> books { get; set; }
       
    }
}
