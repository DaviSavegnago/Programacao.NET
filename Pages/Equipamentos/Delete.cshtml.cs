using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControleEquipamentos.Services;

namespace ControleEquipamentos.Pages.Equipamentos
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(int codigo)
        {
            ArquivoEquipamento arquivo = new ArquivoEquipamento();

            arquivo.Excluir(codigo);

            return RedirectToPage("Index");
        }
    }
}