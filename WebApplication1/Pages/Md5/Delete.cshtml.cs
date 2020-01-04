using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.Md5
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;

        public DeleteModel(WebApplication1.Models.TestBokerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VMd5test VMd5test { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VMd5test = await _context.VMd5test.FirstOrDefaultAsync(m => m.Id == id);

            if (VMd5test == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VMd5test = await _context.VMd5test.FindAsync(id);

            if (VMd5test != null)
            {
                _context.VMd5test.Remove(VMd5test);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
