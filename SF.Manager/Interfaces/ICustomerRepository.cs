using SF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SF_Manager.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetVoluntariosAsync(int id);
        Task<IEnumerable<Customer>> GetVoluntariosAsync();
    }
}
