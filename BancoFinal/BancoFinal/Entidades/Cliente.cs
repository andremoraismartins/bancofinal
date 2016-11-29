using System.ComponentModel.DataAnnotations;

namespace BancoFinal.Entidades
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
    }
}
