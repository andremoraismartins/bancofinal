namespace BancoFinal.Classes
{
    public abstract class Conta
    {
        public Conta(Cliente cliente)
        {
            this.Cliente = cliente;
        }

        public int ConCodigo { get; protected set; }
        public decimal ConSaldo { get; protected set; } = 10.0M;
        public Cliente Cliente { get; private set; }

        public abstract string Sacar(decimal valor);
        public abstract string Depositar(decimal valor);
        public abstract string Transferir(Conta destino, decimal valor);
    }
}
