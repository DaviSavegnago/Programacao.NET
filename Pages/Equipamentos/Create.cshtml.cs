using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControleEquipamentos.Models;
using ControleEquipamentos.Services;

namespace ControleEquipamentos.Pages.Equipamentos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Equipamento Equipamento { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ArquivoEquipamento arquivo = new ArquivoEquipamento();
            bool sucesso = arquivo.Salvar(Equipamento);

            if (!sucesso)
            {
                ModelState.AddModelError("", "Código já existe!");
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}