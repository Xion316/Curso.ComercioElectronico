namespace Curso.ComercioElectronico.HttpApi;

using Curso.ComercioElectronico.Application;
using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoAppService productoAppService;

    public ProductoController(IProductoAppService productoAppService)
    {
        this.productoAppService = productoAppService;
    }

    [HttpGet]
    public ICollection<ProductoDto> GetAll()
    {
        
        return productoAppService.GetAll();
    }

     [HttpGet("buscar_nombre")]
    public IQueryable<ProductoDto> GetByNombre(string searchString)
    {

        return productoAppService.GetByNombre();
    }

    [HttpPost]
    public async Task<ProductoDto> CreateAsync(ProductoCreateUpdateDto productoCreateUpdateDto)
    {

        return await productoAppService.CreateAsync(productoCreateUpdateDto);

    }

    [HttpPut]
    public async Task<ProductoDto> UpdateAsync(string codigoProducto, ProductoCreateUpdateDto productoCreateUpdateDto)
    {

        return await productoAppService.UpdateAsync(codigoProducto, productoCreateUpdateDto);

    }

    [HttpDelete]
    public async Task<bool> DeleteAsync(string codigoProducto)
    {

        return await productoAppService.DeleteAsync(codigoProducto);

    }
    [HttpGet("buscar_por_tipo_producto")]
    IQueryable<ProductoDto> GetByTipoProductoId (Guid productoId, int limit = 10, int offset = 0){

        return productoAppService.GetByTipoProductoId(productoId);

    }
    [HttpGet("buscar_por_marca_id")]
    IQueryable<ProductoDto> GetByMarcaId (Guid marcaId, int limit = 10, int offset = 0){

        return productoAppService.GetByTipoProductoId(marcaId);
    }

}
