using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace HomeSwap.Api.ServiceCollection
{
    public static class ApiServiceCollection
    {
        public static IServiceCollection AddApi(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            return serviceCollection;
        }
    }
}
