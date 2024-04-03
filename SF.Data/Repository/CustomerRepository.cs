using Core.Domain;
using Data.Context;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
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
