using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Pages.UserMd5
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;

        public CreateModel(WebApplication1.Models.TestBokerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Md5TestUser Md5TestUser { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Md5TestUser.Add(Md5TestUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
