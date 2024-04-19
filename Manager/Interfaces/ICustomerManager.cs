using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerManager
    {
        Task<Customer> GetCustomerAsync(int id);
        Task<IEnumerable<Customer>> GetCustomerAsync();
    }
}
