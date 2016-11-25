using BancoFinal.Repositorios;
using System;

namespace BancoFinal.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente, int conCodigo = -1, decimal conSaldo = 0.00M) : base(cliente)
        {
            this.ConCodigo = conCodigo;
            this.ConSaldo = conSaldo;
        }

        public override string Depositar(decimal valor)
        {
            string erros = string.Empty;
            if (this == null || this.ConCodigo <= -1)
            {
                erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de origem!\n";
            }
            if (valor <= 0)
            {
                erros += "Não foi possível realizar o depósito, pois o valor informado é inválido!";
            }

            if (string.IsNullOrEmpty(erros))
            {
                this.ConSaldo += valor;
                return string.Empty;
            }

            return erros;
        }

        public override string Sacar(decimal valor)
        {
            string erros = string.Empty;
            if (this == null || this.ConCodigo <= -1)
            {
                erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de origem!\n";
            }
            if (valor <= 0)
            {
                erros += "Não foi possível realizar o saque, pois o valor informado é inválido!\n";
            }
            if (valor > this.ConSaldo)
            {
                erros += "Não foi possível realizar o saque, pois o saldo atual é menor que o valor informado!\n";
            }

            if (string.IsNullOrEmpty(erros))
            {
                this.ConSaldo -= valor;
                return string.Empty;
            }

            return erros;
        }

        public override string Transferir(Conta destino, decimal valor)
        {
            string erros = string.Empty;
            if (this == null || this.ConCodigo <= -1)
            {
                erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de origem!\n";
            }
            if (destino == null || destino.ConCodigo <= -1)
            {
                erros += "Não foi possível realizar a transferência, pois não foi selecionado uma conta corrente de destino!\n";
            }
            if (valor <= 0)
            {
                erros += "Não foi possível realizar a transferência, pois o valor informado é inválido!\n";
            }
            if (valor > this.ConSaldo)
            {
                erros += "Não foi possível realizar a transferência, pois o saldo atual da conta corrente de origem é menor que o valor informado!\n";
            }

            if (string.IsNullOrEmpty(erros))
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return string.Empty;
            }

            return erros;
        }

        internal string Validar()
        {
            ContaCorrenteRepositorio contaCorrenteRepositorio = new ContaCorrenteRepositorio();
            string erros = string.Empty;

            //Validação do objeto atual
            if (this == null || this.ConCodigo > -1)
            {
                erros += "É necessário selecionar uma conta corrente para validar!\n";
            }

            //Validação da Fk de Cliente
            if (this.Cliente == null || this.Cliente.CliCodigo < 0)
            {
                erros += "É necessário selecionar um cliente para essa conta!\n";
            }

            //Validar cliente único para a conta            
            if (contaCorrenteRepositorio.BuscarPorCliente(this.Cliente.CliCodigo).Count > 0)
            {
                erros += "Esse cliente já possui uma conta corrente, portanto não é possível criar uma nova!\n";
            }

            return erros;
        }
    }
}
