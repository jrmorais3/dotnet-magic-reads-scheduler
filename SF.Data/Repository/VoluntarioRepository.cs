using Microsoft.EntityFrameworkCore;
using SF.Core.Domain;
using SF.Data.Context;
using SF_Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SF_Data.Repository
{
    public class VoluntarioRepository : IVoluntarioRepository
    {
        private readonly SFContext context;

        public VoluntarioRepository(SFContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Voluntario>> GetVoluntariosAsync()
        {
            return await context.Voluntarios.AsNoTracking().ToListAsync();
        }

        public async Task<Voluntario> GetVoluntariosAsync(int id)
        {
            return await context.Voluntarios.FindAsync(id);
        }
    }
}
