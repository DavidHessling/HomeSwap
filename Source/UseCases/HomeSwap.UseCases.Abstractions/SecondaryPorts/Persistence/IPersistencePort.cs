using HomeSwap.BusinessModels.Abstractions.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeSwap.UseCases.Abstractions.SecondaryPorts.Persistence
{
    public interface IPersistencePort
    {
        Task<IEnumerable<IHome>> GetHomes();
    }
}
