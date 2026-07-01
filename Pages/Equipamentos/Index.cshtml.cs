using Microsoft.AspNetCore.Mvc.RazorPages;
using ControleEquipamentos.Models;
using ControleEquipamentos.Services;

namespace ControleEquipamentos.Pages.Equipamentos
{
    public class IndexModel : PageModel
    {
        public List<Equipamento> Equipamentos { get; set; } = new();

        public void OnGet()
        {
            ArquivoEquipamento arquivo = new ArquivoEquipamento();
            Equipamentos = arquivo.LerTodos();
        }
    }
}