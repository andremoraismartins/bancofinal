using System.Collections.Generic;

namespace BancoFinal.Repositorios.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        void Adicionar(T objeto);
        void Alterar(int codigo, T objetoAlterado);
        T BuscarPorCodigo(int codigo);
        void Excluir(int codigo);
        IEnumerable<T> Listar();
    }
}
