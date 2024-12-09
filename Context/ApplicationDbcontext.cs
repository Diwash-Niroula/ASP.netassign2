using Microsoft.EntityFrameworkCore;
using BookExchange.Models;

namespace BookExchange.Context
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> contextOptions)
            : base(contextOptions)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}
