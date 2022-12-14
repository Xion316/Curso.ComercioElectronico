using AutoMapper;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application.Mapeos;

public class ConfiguracionesMapeoProfile: Profile
{
    //TipoProductoCrearActualizarDto => TipoProducto
    //TipoProducto => TipoProductoDto
    
    //MarcaCreateUpdateDto -> Marca
    public ConfiguracionesMapeoProfile()
    {
        CreateMap<TipoProductoCreateUpdateDto, TipoProducto>();
        CreateMap<TipoProducto, TipoProductoDto>();
        
        CreateMap<MarcaCreateUpdateDto, Marca>();
        CreateMap<Marca, MarcaDto>();

        CreateMap<ClienteCreateUpdateDto, Cliente>();
        CreateMap<Cliente, ClienteDto>();
        CreateMap<Cliente, ICollection<ClienteDto>>();

        CreateMap<ProductoCreateUpdateDto, Producto>();
        CreateMap<Producto, ProductoDto>();

        CreateMap<CarritoCreateUpdateDto, Carrito>();
        CreateMap<Carrito, CarritoDto>();
        
             CreateMap<EntregaCreateUpdateDto, Entrega>();
        CreateMap<Entrega, EntregaDto>();
        //TODO: Agregar otros mapeos que se requieren...

    }
}