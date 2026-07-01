using System.ComponentModel.DataAnnotations;

namespace ControleEquipamentos.Models
{
    public class Equipamento
    {
        [Required(ErrorMessage = "Informe o código.")]
        [Range(1, int.MaxValue, ErrorMessage = "O código DEVE ser maior que zero.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Informe o nome!")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "Informe o patrimônio.")]
        [MinLength(6, ErrorMessage = "O patrimônio deve ter no mínimo 6 caracteres.")]
        public string Patrimonio { get; set; } = "";

        [Required(ErrorMessage = "Informe o e-mail.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Informe a situação.")]
        public SituacaoEquipamento Situacao { get; set; }
    }
}