using HomeSwap.BusinessModels.Abstractions.Entities;
using HomeSwap.BusinessModels.Abstractions.ValueObjects;

namespace HomeSwap.Core.Models
{
    public class Home : IHome
    {
        public ISize Size { get; set; }

        public IRent Rent { get; set; }
    }
}
