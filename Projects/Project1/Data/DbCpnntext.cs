using Microsoft.EntityFrameworkCore;

namespace Project1.Data
{
    public class DbCpnntext
    {
        private DbContextOptions<AppDbContext> options;

        public DbCpnntext(DbContextOptions<AppDbContext> options)
        {
            this.options = options;
        }
    }
}