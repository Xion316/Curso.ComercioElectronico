namespace Curso.ComercioElectronico.Domain;

public interface ITipoProductoRepository: IRepository<TipoProducto,Guid>
{
    Task<bool> ExisteNombre(string nombre);

    Task<bool> ExisteNombre(string nombre, Guid idExcluir);

    //Task<IQueryable<TipoProducto>> GetByText(int limit=0, int offset=0, string propiedad="", string candenaBuscar="");
}
