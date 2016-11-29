using BancoFinal.Entidades;
using BancoFinal.Repositorios;
using BancoFinal.Servicos.Interfaces;

namespace BancoFinal.Servicos
{
    public class ClienteServico : IClienteServico
    {
        public string Erros { get; private set; }

        private ClienteRepositorio ClienteRepositorio { get; set; } = new ClienteRepositorio();
        private ContaCorrenteRepositorio ContaCorrenteRepositorio { get; set; } = new ContaCorrenteRepositorio();

        public void Adicionar(Cliente objeto)
        {
            Erros = string.Empty;

            //Validar Data Annotations
            Erros = Validacao.ValidarObjeto(objeto);

            if (objeto == null)
                Erros += "É necessário selecionar um cliente para validar!\n";

            //Validar dígitos do CPF
            if (!Validacao.ValidarCpf(objeto.CliCpf))
                Erros += "CPF informado é inválido!\n";

            //Validar CPF único
            if (ClienteRepositorio.BuscarPorCpf(objeto.CliCpf) != null)
                Erros += "CPF informado deve ser único!\n";

            if (string.IsNullOrEmpty(Erros))
                ClienteRepositorio.Adicionar(objeto);
        }

        public void Alterar(Cliente objeto)
        {
            Erros = string.Empty;

            //Validar Data Annotations
            Erros = Validacao.ValidarObjeto(objeto);

            if (objeto == null || objeto.CliCodigo < 0)
                Erros += "É necessário selecionar um cliente para validar!\n";

            //Validar dígitos do CPF
            if (!Validacao.ValidarCpf(objeto.CliCpf))
                Erros += "CPF informado é inválido!\n";

            //Validar CPF único
            Cliente clienteCpf = ClienteRepositorio.BuscarPorCpf(objeto.CliCpf);
            if (clienteCpf != null && objeto.CliCodigo != clienteCpf.CliCodigo)
                Erros += "CPF informado deve ser único!\n";

            if (string.IsNullOrEmpty(Erros))
                ClienteRepositorio.Alterar(objeto);
        }

        public void Excluir(int codigo)
        {
            Erros = string.Empty;

            Cliente cliente = ClienteRepositorio.BuscarPorCodigo(codigo);

            //Validar se o registro da conta de origem foi encontrado no banco
            if (cliente == null || cliente.CliCodigo < 0)
                Erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de origem!\n";

            if (ContaCorrenteRepositorio.BuscarPorCliente(cliente.CliCodigo).Count > 0)
                Erros += "Não é possível excluir este cliente, pois existe uma conta corrente cadastrada para ele!\n";

            if (string.IsNullOrEmpty(Erros))
                ClienteRepositorio.Excluir(cliente.CliCodigo);
        }
    }
}
