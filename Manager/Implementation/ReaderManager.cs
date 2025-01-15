using Core.Domain;
using Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Implementation
{
    public class ReaderManager(IReaderRepository ReaderRepository) : IReaderManager
    {
        private readonly IReaderRepository readerRepository = ReaderRepository;

        public async Task<IEnumerable<Reader>> GetReaderAsync()
        {
            return await readerRepository.GetReadersAsync();
        }

        public async Task<Reader> GetReaderAsync(int id)
        {
            return await readerRepository.GetReaderAsync(id);
        }
    }
}
