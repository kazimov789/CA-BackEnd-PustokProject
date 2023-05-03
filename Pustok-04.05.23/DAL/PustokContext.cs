using Microsoft.EntityFrameworkCore;
using Pustok_04._05._23.Models;

namespace Pustok_04._05._23.DAL
{
    public class PustokContext:DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options):base(options) { }
        DbSet<Books> Books { get; set; }
        DbSet<BooksImage> BooksImages { get; set; }
    }
}
