using SF.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SF_Manager.Interfaces
{
    public interface ICustomerManager
    {
        Task<Customer> GetCustomerAsync(int id);
        Task<IEnumerable<Customer>> GetCustomerAsync();
    }
}
