namespace BancoFinal.Entidades
{
    public abstract class Conta
    {
        public Conta(Cliente cliente)
        {
            this.Cliente = cliente;
        }

        public int ConCodigo { get; set; }
        public decimal ConSaldo { get; set; } = 10.0M;
        public Cliente Cliente { get; set; }
    }
}
