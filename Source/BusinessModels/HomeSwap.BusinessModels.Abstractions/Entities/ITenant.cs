using HomeSwap.BusinessModels.Abstractions.ValueObjects;

namespace HomeSwap.BusinessModels.Abstractions.Entities
{
    public interface ITenant
    {
        IContact Contact { get; set; }

        IHome CurrentHome { get; set; }

        IHome DesiredHome { get; set; }
    }
}
