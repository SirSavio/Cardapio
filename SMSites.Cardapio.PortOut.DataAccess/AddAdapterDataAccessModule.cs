using Microsoft.Extensions.DependencyInjection;
using SMSites.Cardapio.PortOut.DataAccess.Context;
using SMSites.Cardapio.PortOut.DataAccess.Repositories.Admin;
using Microsoft.EntityFrameworkCore;

namespace SMSites.Cardapio.PortOut.DataAccess
{
    public static class AddAdapterDataAccessModule
    {
        public static IServiceCollection AddAdapterDataAccess(this IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<Database>(
                options => options
                .UseNpgsql("Host=107.173.84.179;Port=5432;Pooling=true;Database=Cadastro;User Id=admin;Password=testdevelopment;"));
            services.AddScoped<ProductRepository>();
            services.AddScoped<CupomRepository>();
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "http://107.173.84.179:6379/";
            });

            return services;
        }
    }
}
