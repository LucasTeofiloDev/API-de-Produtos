using ApiDeProdutos.Model.Context;
using Microsoft.EntityFrameworkCore;



namespace ApiDeProdutos.Configurations
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDatabaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var configurationDatabase = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(configurationDatabase))
            {
                throw new Exception("Configuração do banco esta nula ou vazia");
            }
            services.AddDbContext<MSSQLContext>(options =>

            options.UseSqlServer(configurationDatabase)
            );
            return services;
        }


    }
}
