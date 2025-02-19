using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppTeste.Models;

namespace AppTeste.Pages.Aneis
{
    public class CreateModel : PageModel
    {
        private readonly AppTeste.Data.AppTesteContext _context;

        public CreateModel(AppTeste.Data.AppTesteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ring Ring { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ring.Add(Ring);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
