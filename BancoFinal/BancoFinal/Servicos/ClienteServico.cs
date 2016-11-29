using BancoFinal.Entidades;
using BancoFinal.Repositorios;
using BancoFinal.Servicos.Interfaces;

namespace BancoFinal.Servicos
{
    public class ClienteServico : IClienteServico
    {
        public string Erros { get; private set; }

        private ClienteRepositorio ClienteRepositorio { get; set; } = new ClienteRepositorio();

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
    }
}
