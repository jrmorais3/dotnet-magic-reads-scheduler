using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetVoluntariosAsync(int id);
        Task<IEnumerable<Customer>> GetVoluntariosAsync();
    }
}
