using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.UserMd5
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;

        public DetailsModel(WebApplication1.Models.TestBokerContext context)
        {
            _context = context;
        }

        public Md5TestUser Md5TestUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Md5TestUser = await _context.Md5TestUser.FirstOrDefaultAsync(m => m.Id == id);

            if (Md5TestUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
