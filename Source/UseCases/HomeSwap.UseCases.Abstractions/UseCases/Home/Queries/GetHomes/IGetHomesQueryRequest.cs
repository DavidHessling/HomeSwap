using HomeSwap.BusinessModels.Abstractions.Entities;
using MediatR;
using System.Collections.Generic;

namespace HomeSwap.UseCases.Abstractions.Home.Queries.GetHomes
{
    public interface IGetHomesQueryRequest : IRequest<IEnumerable<IHome>>
    {
    }
}
