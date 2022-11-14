namespace Curso.ComercioElectronico.Domain;

public interface IProductoRepository: IRepository<Producto,Guid>
{
     Task<bool> ExisteProducto(string codigoProducto);

     Task<Producto> GetByCodigo(string codigoProducto);

     // public Task<Producto> GetByText (int limit = 10, int offset = 0, string searchString="");

}
