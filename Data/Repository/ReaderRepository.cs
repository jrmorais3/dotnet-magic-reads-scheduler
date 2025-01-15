using Core.Domain;
using Data.Context;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public class ReaderRepository : IReaderRepository
    {
        private readonly MRSContext context;

        public ReaderRepository(MRSContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Reader>> GetReadersAsync()
        {
            return await context.Voluntarios.AsNoTracking().ToListAsync();
        }

        public async Task<Reader> GetReaderAsync(int id)
        {
            return await context.Voluntarios.FindAsync(id);
        }
    }
}
