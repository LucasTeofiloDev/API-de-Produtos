using Serilog;

namespace ApiDeProdutos.Configurations
{
    public static class LogConfig
    {
        public static IHostBuilder AddSerilogConfig(
            this IHostBuilder host,
            IConfiguration configuration)
        {
            return host.UseSerilog((_, services, loggerConfiguration) =>
                loggerConfiguration
                    .ReadFrom.Configuration(configuration)
                    .ReadFrom.Services(services));
        }
    }
}
