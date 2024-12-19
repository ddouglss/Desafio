using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppTeste.Data;
using AppTeste.Models;

namespace AppTeste.Pages.Aneis
{
    public class DetailsModel : PageModel
    {
        private readonly AppTeste.Data.AppTesteContext _context;

        public DetailsModel(AppTeste.Data.AppTesteContext context)
        {
            _context = context;
        }

        public Ring Ring { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ring = await _context.Ring.FirstOrDefaultAsync(m => m.Id == id);
            if (ring == null)
            {
                return NotFound();
            }
            else
            {
                Ring = ring;
            }
            return Page();
        }
    }
}
