using entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.Efcore.config
{
    public class Bookconfig
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                new Book { Id = 1, Title = "a", Prize = 10 },
                new Book { Id = 2, Title = "b", Prize = 20 },
                new Book { Id = 3, Title = "c", Prize = 30 }

                );
        }
    }
}
