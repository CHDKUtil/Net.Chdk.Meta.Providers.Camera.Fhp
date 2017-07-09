using Microsoft.Extensions.DependencyInjection;
using Net.Chdk.Meta.Providers.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Fhp
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFhpProviders(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddSingleton<IBootProvider, FhpBootProvider>()
                .AddSingleton<IEosCardProvider, FhpCardProvider>();
        }
    }
}
