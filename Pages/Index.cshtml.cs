using AppTeste.Data;
using AppTeste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AppTeste.Pages
{
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppTesteContext _context;


        public IList<Ring> Rings { get; set; } = new List<Ring>();

        [BindProperty]
        public Ring Ring { get; set; } = new Ring {
            Poder = "",
            Nome = "",
            ForjadoPor = "",
            Imagem = "Anéis"
        };

        public IndexModel(ILogger<IndexModel> logger, AppTesteContext context) {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync() {
            Rings = await _context.Ring.ToListAsync();
        }
        

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Ring.Add(Ring);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Aneis/Details", new { id = Ring.Id });


        }
    }

}
