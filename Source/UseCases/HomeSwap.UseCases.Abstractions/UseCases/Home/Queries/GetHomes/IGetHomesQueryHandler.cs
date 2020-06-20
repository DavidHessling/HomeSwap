using HomeSwap.BusinessModels.Abstractions.Entities;
using MediatR;
using System.Collections.Generic;

namespace HomeSwap.UseCases.Abstractions.Home.Queries.GetHomes
{
    public interface IGetHomesQueryHandler : IRequestHandler<IGetHomesQueryRequest, IEnumerable<IHome>>
    {
    }
}
