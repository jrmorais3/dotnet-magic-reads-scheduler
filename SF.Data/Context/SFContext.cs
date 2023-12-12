using Microsoft.EntityFrameworkCore;
using SF.Core.Domain;

namespace SF.Data.Context
{
    public class SFContext : DbContext
    {
        public DbSet<Voluntario> Voluntarios { get; set; }

        public SFContext(DbContextOptions options) : base(options)
        {
        }
    }
}
