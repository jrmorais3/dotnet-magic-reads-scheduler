using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IReaderManager
    {
        Task<Reader> GetReaderAsync(int id);
        Task<IEnumerable<Reader>> GetReaderAsync();
    }
}
