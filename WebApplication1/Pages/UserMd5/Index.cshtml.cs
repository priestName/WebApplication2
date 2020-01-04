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
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;

        public IndexModel(WebApplication1.Models.TestBokerContext context)
        {
            _context = context;
        }

        public IList<Md5TestUser> Md5TestUser { get;set; }

        public async Task OnGetAsync()
        {
            Md5TestUser = await _context.Md5TestUser.ToListAsync();
        }
    }
}
