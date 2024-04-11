using Core.Domain;
using Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Implementation
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository voluntarioRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            this.voluntarioRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetCustomerAsync()
        {
            return await voluntarioRepository.GetCustomersAsync();
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await voluntarioRepository.GetCustomerAsync(id);
        }
    }
}
