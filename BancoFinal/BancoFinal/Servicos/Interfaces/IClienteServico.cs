using BancoFinal.Entidades;
using BancoFinal.Repositorios;

namespace BancoFinal.Servicos.Interfaces
{
    public interface IClienteServico
    {
        string Erros { get; }

        ClienteRepositorio ClienteRepositorio { get; }

        void Adicionar(Cliente objeto);

        void Alterar(int codigo, Cliente objeto);
    }
}
