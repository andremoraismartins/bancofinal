using BancoFinal.Entidades;
using System.Collections.Generic;

namespace BancoFinal.Repositorios.Interfaces
{
    public interface IContaCorrenteRepositorio : IRepositorio<ContaCorrente>
    {
        List<ContaCorrente> BuscarPorCliente(int cliCodigo);
    }
}
