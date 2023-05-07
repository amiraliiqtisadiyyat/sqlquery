using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Pustok.DAL
{
   public  class PustokContext:DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options)
        {

        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }

    }
}
