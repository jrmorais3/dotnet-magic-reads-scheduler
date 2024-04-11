using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerAsync(int id);
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
