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
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;
        public static int PageIndex = 0;

        public IndexModel(WebApplication1.Models.TestBokerContext context)
        {
            _context = context;
        }

        public IList<VMd5test> VMd5test { get;set; }

        public async Task OnGetAsync()
        {
            VMd5test = await _context.VMd5test.Skip(PageIndex * 20).Take(20).ToListAsync();
        }
    }
}
