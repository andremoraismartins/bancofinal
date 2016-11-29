using BancoFinal.Entidades;
using BancoFinal.Repositorios;

namespace BancoFinal.Servicos.Interfaces
{
    public interface IContaCorrenteServico
    {
        string Erros { get; }

        void Adicionar(ContaCorrente objeto);

        void Alterar(int codigo, ContaCorrente objeto);

        void Depositar(int codigo, decimal valor);

        void Sacar(int codigo, decimal valor);

        void Transferir(int codigoOrigem, int codigoDestino, decimal valor);
    }
}
