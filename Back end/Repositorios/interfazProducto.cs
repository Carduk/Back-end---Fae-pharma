using Back_end.Entidades;

namespace Back_end.Repositorios
{
    public interface interfazProducto
    {
        producto buscarProducto(int id);
        List<producto> getProductos();
    }
}
