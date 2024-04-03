using Core.Domain;
using Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Implementation
{
    public class VoluntarioManager : ICustomerManager
    {
        private readonly ICustomerRepository voluntarioRepository;

        public VoluntarioManager(ICustomerRepository voluntarioRepository)
        {
            this.voluntarioRepository = voluntarioRepository;
        }

        public async Task<IEnumerable<Customer>> GetCustomerAsync()
        {
            return await voluntarioRepository.GetVoluntariosAsync();
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await voluntarioRepository.GetVoluntariosAsync(id);
        }
    }
}
