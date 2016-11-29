using BancoFinal.Entidades;

namespace BancoFinal.Servicos.Interfaces
{
    public interface IClienteServico
    {
        string Erros { get; }

        void Adicionar(Cliente objeto);

        void Alterar(Cliente objeto);

        void Excluir(int codigo);
    }
}
