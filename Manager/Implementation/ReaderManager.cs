using Core.Domain;
using Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Implementation
{
    public class ReaderManager : IReaderManager
    {
        private readonly IReaderRepository voluntarioRepository;

        public ReaderManager(IReaderRepository ReaderRepository)
        {
            this.voluntarioRepository = ReaderRepository;
        }

        public async Task<IEnumerable<Reader>> GetReaderAsync()
        {
            return await voluntarioRepository.GetReadersAsync();
        }

        public async Task<Reader> GetReaderAsync(int id)
        {
            return await voluntarioRepository.GetReaderAsync(id);
        }
    }
}
