using HomeSwap.BusinessModels.Abstractions.Entities;
using HomeSwap.UseCases.Abstractions.Home.Queries.GetHomes;
using HomeSwap.UseCases.Abstractions.SecondaryPorts.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HomeSwap.UseCases.Home.Queries
{
    public class GetHomesQueryHandler : IGetHomesQueryHandler
    {
        private readonly IPersistencePort _persistencePort;

        public GetHomesQueryHandler(IPersistencePort persistencePort)
        {
            _persistencePort = persistencePort;
        }

        public async Task<IEnumerable<IHome>> Handle(IGetHomesQueryRequest request, CancellationToken cancellationToken)
        {
            return await _persistencePort.GetHomes();
        }
    }
}
