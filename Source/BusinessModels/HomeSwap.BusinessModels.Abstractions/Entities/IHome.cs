using HomeSwap.BusinessModels.Abstractions.ValueObjects;

namespace HomeSwap.BusinessModels.Abstractions.Entities
{
    public interface IHome
    {
        ISize Size { get; set; }

        IRent Rent { get; set; }
    }
}
