using SF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SF_Manager.Interfaces
{
    public interface IVoluntarioManager
    {
        Task<Voluntario> GetVoluntariosAsync(int id);
        Task<IEnumerable<Voluntario>> GetVoluntariosAsync();
    }
}
