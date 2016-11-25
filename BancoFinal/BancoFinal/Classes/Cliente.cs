using System.ComponentModel.DataAnnotations;

namespace BancoFinal.Classes
{
    public class Cliente
    {
        public int CliCodigo { get; set; }

        [Required(ErrorMessage = "Nome do cliente é obrigatório!")]
        [StringLength(50, ErrorMessage = "Nome do cliente deve ter no máximo 50 caracteres!")]
        public string CliNome { get; set; }

        [Required(ErrorMessage = "CPF do cliente é obrigatório!")]
        [StringLength(15, MinimumLength = 14, ErrorMessage = "CPF do cliente deve ter 14 caracteres!")]
        public string CliCpf { get; set; }

        public string Validar()
        {
            //Validar Data Annotations
            string erros = Validacao.ValidarObjeto(this);
            //Validar dígitos do CPF
            if (!Validacao.ValidarCpf(this.CliCpf))
            {
                erros += "CPF informado é inválido!\n";
            }
            //Validar CPF único
            Repositorios.ClienteRepositorio clienteRepo = new Repositorios.ClienteRepositorio();
            Cliente clienteCpf = clienteRepo.BuscarPorCpf(this.CliCpf);
            if (clienteCpf != null && (this.CliCodigo == 0 || this.CliCodigo != clienteCpf.CliCodigo))
            {
                erros += "CPF informado deve ser único!\n";
            }

            return erros;
        }
    }
}
