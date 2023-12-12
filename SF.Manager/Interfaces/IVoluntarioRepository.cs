using SF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SF_Manager.Interfaces
{
    public interface IVoluntarioRepository
    {
        Task<Voluntario> GetVoluntariosAsync(int id);
        Task<IEnumerable<Voluntario>> GetVoluntariosAsync();
    }
}
