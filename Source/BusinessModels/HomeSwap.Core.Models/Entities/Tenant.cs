using HomeSwap.BusinessModels.Abstractions.Entities;
using HomeSwap.BusinessModels.Abstractions.ValueObjects;

namespace HomeSwap.BusinessModels.Entities
{
    public class Tenant : ITenant
    {
        public IContact Contact { get; set; }

        public IHome CurrentHome { get; set; }

        public IHome DesiredHome { get; set; }
    }
}
