using SF.Core.Domain;
using SF_Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SF_Manager.Implementation
{
    public class VoluntarioManager : IVoluntarioManager
    {
        private readonly IVoluntarioRepository voluntarioRepository;

        public VoluntarioManager(IVoluntarioRepository voluntarioRepository)
        {
            this.voluntarioRepository = voluntarioRepository;
        }

        public async Task<IEnumerable<Voluntario>> GetVoluntariosAsync()
        {
            return await voluntarioRepository.GetVoluntariosAsync();
        }

        public async Task<Voluntario> GetVoluntariosAsync(int id)
        {
            return await voluntarioRepository.GetVoluntariosAsync(id);
        }
    }
}
