using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControleEquipamentos.Models;
using ControleEquipamentos.Services;

namespace ControleEquipamentos.Pages.Equipamentos
{
    public class DetailsModel : PageModel
    {
        public Equipamento? Equipamento { get; set; }

        public IActionResult OnGet(int codigo)
        {
            ArquivoEquipamento arquivo = new ArquivoEquipamento();

            Equipamento = arquivo.BuscarPorCodigo(codigo);

            if (Equipamento == null)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        public string Mascara(string valor)
        {
            return "********";
        }
    }
}