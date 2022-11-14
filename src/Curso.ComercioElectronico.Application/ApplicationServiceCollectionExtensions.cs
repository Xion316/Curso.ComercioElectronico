using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Curso.ComercioElectronico.Application;

public static class ApplicationServiceCollectionExtensions
{
    
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration config)
    {

        services.AddTransient<IMarcaAppService, MarcaAppService>();
        services.AddTransient<ITipoProductoAppService, TipoProductoAppservice>();
        services.AddTransient<IProductoAppService, ProductoAppService>();
        services.AddTransient<IClienteAppService, ClienteAppService>();
        services.AddTransient<ICarritoAppService, CarritoAppService>();
        services.AddTransient<IEntregaAppService, EntregaAppService>();

        //Configurar la inyección de todos los profile que existen en un Assembly
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

       
        return services;
}
}
