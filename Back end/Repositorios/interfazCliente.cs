using Back_end.Entidades;

namespace Back_end.Repositorios
{
    public interface interfazCliente
    {
        cliente comprobarCliente(string run);
        List<cliente> verClientes();
    }
}