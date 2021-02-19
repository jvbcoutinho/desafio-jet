using BlueModas.Application.PedidoAggregate;
using BlueModas.Application.ProdutoAggregate;
using BlueModas.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlueModas.Application
{
    public static class ConfigurationModule
    {
        public static void RegisterStoreService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.RegisterRepository(configuration.GetConnectionString("connectionString"));
        }

    }
}