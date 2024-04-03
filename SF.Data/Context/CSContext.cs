using Microsoft.EntityFrameworkCore;
using SF.Core.Domain;

namespace SF.Data.Context
{
    public class CSContext : DbContext
    {
        public DbSet<Customer> Voluntarios { get; set; }

        public CSContext(DbContextOptions options) : base(options)
        {
        }
    }
}
