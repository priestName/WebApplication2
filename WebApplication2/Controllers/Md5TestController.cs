using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Md5TestController : Controller
    {
        private readonly TestBokerContext _context;
        public static int PageIndex = 0;

        public Md5TestController(TestBokerContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Md5Test.Skip(PageIndex * 20).Take(20).ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var md5Test = await _context.Md5Test
                .FirstOrDefaultAsync(m => m.Id == id);
            if (md5Test == null)
            {
                return NotFound();
            }

            return View(md5Test);
        }

        public IActionResult Create()
        {
            return View();
        }

        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Key,Value")] Md5Test md5Test)
        {
            if (ModelState.IsValid)
            {
                _context.Add(md5Test);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(md5Test);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var md5Test = await _context.Md5Test.FindAsync(id);
            if (md5Test == null)
            {
                return NotFound();
            }
            return View(md5Test);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Key,Value")] Md5Test md5Test)
        {
            if (id != md5Test.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(md5Test);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Md5TestExists(md5Test.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(md5Test);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var md5Test = await _context.Md5Test
                .FirstOrDefaultAsync(m => m.Id == id);
            if (md5Test == null)
            {
                return NotFound();
            }

            return View(md5Test);
        }
        [System.Web.Http.HttpPost, System.Web.Http.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var md5Test = await _context.Md5Test.FindAsync(id);
            _context.Md5Test.Remove(md5Test);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Md5TestExists(int id)
        {
            return _context.Md5Test.Any(e => e.Id == id);
        }
    }
}
