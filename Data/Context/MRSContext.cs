using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MRSContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Reader> Voluntarios { get; set; }
    }
}
