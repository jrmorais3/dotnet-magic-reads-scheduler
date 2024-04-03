using Microsoft.EntityFrameworkCore;
using SF.Core.Domain;
using SF.Data.Context;
using SF_Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SF_Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CSContext context;

        public CustomerRepository(CSContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Customer>> GetVoluntariosAsync()
        {
            return await context.Voluntarios.AsNoTracking().ToListAsync();
        }

        public async Task<Customer> GetVoluntariosAsync(int id)
        {
            return await context.Voluntarios.FindAsync(id);
        }
    }
}
