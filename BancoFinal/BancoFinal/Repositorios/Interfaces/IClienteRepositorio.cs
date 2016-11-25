using BancoFinal.Classes;

namespace BancoFinal.Repositorios.Interfaces
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        Cliente BuscarPorCpf(string cliCpf);
    }
}
