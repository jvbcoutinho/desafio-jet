
using BlueModas.Domain.Cesta;
using BlueModas.Domain.Pedido;
using BlueModas.Domain.Produto;
using BlueModas.Repository.Context;
using BlueModas.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlueModas.Repository
{
    public static class ConfigurationModule
    {
        public static void RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ModaContext>(opt =>
            {
                opt.UseInMemoryDatabase(connectionString);
            });

            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<ICestaRepository, CestaRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
        }
    }
}