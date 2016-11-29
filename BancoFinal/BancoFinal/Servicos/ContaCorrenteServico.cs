using BancoFinal.Servicos.Interfaces;
using System;
using BancoFinal.Entidades;
using BancoFinal.Repositorios;

namespace BancoFinal.Servicos
{
    public class ContaCorrenteServico : IContaCorrenteServico
    {
        public string Erros { get; private set; }

        private ContaCorrenteRepositorio ContaCorrenteRepositorio { get; set; } = new ContaCorrenteRepositorio();

        public void Adicionar(ContaCorrente objeto)
        {
            Erros = string.Empty;

            //Validar Data Annotations
            Erros = Validacao.ValidarObjeto(objeto);

            //Validação do objeto atual
            if (objeto == null)
                Erros += "É necessário selecionar uma conta corrente para validar!\n";

            //Validação da Fk de Cliente
            if (objeto.Cliente == null || objeto.Cliente.CliCodigo < 0)
                Erros += "É necessário selecionar um cliente para essa conta!\n";

            //Validar cliente único para a conta            
            if (ContaCorrenteRepositorio.BuscarPorCliente(objeto.Cliente.CliCodigo).Count > 0)
                Erros += "Esse cliente já possui uma conta corrente, portanto não é possível criar uma nova!\n";

            if (string.IsNullOrEmpty(Erros))
                ContaCorrenteRepositorio.Adicionar(objeto);
        }

        public void Alterar(ContaCorrente objeto)
        {
            Erros = string.Empty;

            //Validar Data Annotations
            Erros = Validacao.ValidarObjeto(objeto);

            //Validação do objeto atual
            if (objeto == null || objeto.ConCodigo < 0)
                Erros += "É necessário selecionar uma conta corrente para validar!\n";

            //Validação da Fk de Cliente
            if (objeto.Cliente == null || objeto.Cliente.CliCodigo < 0)
                Erros += "É necessário selecionar um cliente para essa conta!\n";

            //Validar cliente único para a conta            
            if (ContaCorrenteRepositorio.BuscarPorCliente(objeto.Cliente.CliCodigo).Count > 0)
                Erros += "Esse cliente já possui uma conta corrente, portanto não é possível criar uma nova!\n";

            if (string.IsNullOrEmpty(Erros))
                ContaCorrenteRepositorio.Alterar(objeto);
        }

        public void Depositar(int codigo, decimal valor)
        {
            Erros = string.Empty;

            ContaCorrente contaCorrente = ContaCorrenteRepositorio.BuscarPorCodigo(codigo);
            
            //Validar se o registro foi encontrado no banco
            if (contaCorrente == null || contaCorrente.ConCodigo < 0)
                Erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de origem!\n";

            //Validar o valor depositado
            if (valor <= 0)
                Erros += "Não foi possível realizar o depósito, pois o valor informado é inválido!";

            if (string.IsNullOrEmpty(Erros))
            {
                contaCorrente.ConSaldo += valor;
                ContaCorrenteRepositorio.Alterar(contaCorrente);
            }            
        }

        public void Sacar(int codigo, decimal valor)
        {
            Erros = string.Empty;

            ContaCorrente contaCorrente = ContaCorrenteRepositorio.BuscarPorCodigo(codigo);

            //Validar se o registro foi encontrado no banco
            if (contaCorrente == null || contaCorrente.ConCodigo < 0)
                Erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de origem!\n";

            //Validar o valor sacado
            if (valor <= 0)
                Erros += "Não foi possível realizar o depósito, pois o valor informado é inválido!";

            //Validar se existe saldo suficiente para o saque
            if (valor > contaCorrente.ConSaldo)
                Erros += "Não foi possível realizar o saque, pois o saldo atual é menor que o valor informado!\n";

            if (string.IsNullOrEmpty(Erros))
            {
                contaCorrente.ConSaldo -= valor;
                ContaCorrenteRepositorio.Alterar(contaCorrente);
            }
        }

        public void Transferir(int codigoOrigem, int codigoDestino, decimal valor)
        {
            Erros = string.Empty;

            ContaCorrente contaCorrenteOrigem = ContaCorrenteRepositorio.BuscarPorCodigo(codigoOrigem);
            ContaCorrente contaCorrenteDestino = ContaCorrenteRepositorio.BuscarPorCodigo(codigoDestino);
            
            //Validar se o registro da conta de origem foi encontrado no banco
            if (contaCorrenteOrigem == null || contaCorrenteOrigem.ConCodigo <= -1)
                Erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de origem!\n";

            //Validar se o registro da conta de destino foi encontrado no banco
            if (contaCorrenteDestino == null || contaCorrenteDestino.ConCodigo <= -1)
                Erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de destino!\n";

            //Validar o valor sacado
            if (valor <= 0)
                Erros += "Não foi possível realizar a transferência, pois o valor informado é inválido!\n";

            //Validar se existe saldo suficiente para a transferência
            if (valor > contaCorrenteOrigem.ConSaldo)
                Erros += "Não foi possível realizar a transferência, pois o saldo atual da conta corrente de origem é menor que o valor informado!\n";

            if (string.IsNullOrEmpty(Erros))
            {
                contaCorrenteOrigem.ConSaldo -= valor;
                contaCorrenteDestino.ConSaldo += valor;
                ContaCorrenteRepositorio.Alterar(contaCorrenteOrigem);
                ContaCorrenteRepositorio.Alterar(contaCorrenteDestino);
            }

        }
    }
}
