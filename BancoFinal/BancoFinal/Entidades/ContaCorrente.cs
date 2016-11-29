namespace BancoFinal.Entidades
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente, int conCodigo = -1, decimal conSaldo = 0.00M) : base(cliente)
        {
            this.ConCodigo = conCodigo;
            this.ConSaldo = conSaldo;
        }
    }
}
