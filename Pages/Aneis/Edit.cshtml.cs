using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppTeste.Data;
using AppTeste.Models;

namespace AppTeste.Pages.Aneis
{
    public class EditModel : PageModel
    {
        private readonly AppTeste.Data.AppTesteContext _context;

        public EditModel(AppTeste.Data.AppTesteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ring Ring { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ring =  await _context.Ring.FirstOrDefaultAsync(m => m.Id == id);
            if (ring == null)
            {
                return NotFound();
            }
            Ring = ring;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ring).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RingExists(Ring.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RingExists(int id)
        {
            return _context.Ring.Any(e => e.Id == id);
        }
    }
}
