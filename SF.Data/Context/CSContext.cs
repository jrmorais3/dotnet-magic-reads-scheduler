using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class CSContext : DbContext
    {
        public DbSet<Customer> Voluntarios { get; set; }

        public CSContext(DbContextOptions options) : base(options)
        {
        }
    }
}
