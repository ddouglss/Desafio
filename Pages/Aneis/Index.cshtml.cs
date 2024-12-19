using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTeste.Models;

namespace AppTeste.Pages.Aneis
{
    public class IndexModel : PageModel
    {
        private readonly AppTeste.Data.AppTesteContext _context;

        public IndexModel(AppTeste.Data.AppTesteContext context)
        {
            _context = context;
        }

        public IList<Ring> Ring { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Ring = await _context.Ring.ToListAsync();
        }
    }
}
