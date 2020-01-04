using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.UserMd5
{
    public class EditModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;

        public EditModel(WebApplication1.Models.TestBokerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Md5TestUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Md5TestUserExists(Md5TestUser.Id))
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

        private bool Md5TestUserExists(int id)
        {
            return _context.Md5TestUser.Any(e => e.Id == id);
        }
    }
}
