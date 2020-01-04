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
    public class DetailsModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;

        public DetailsModel(WebApplication1.Models.TestBokerContext context)
        {
            _context = context;
        }

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
    }
}
