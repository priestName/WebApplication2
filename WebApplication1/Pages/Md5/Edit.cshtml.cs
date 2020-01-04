using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.Md5
{
    public class EditModel : PageModel
    {
        private readonly WebApplication1.Models.TestBokerContext _context;

        public EditModel(WebApplication1.Models.TestBokerContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            switch (VMd5test.TableType)
            {
                case 0:
                    Md5Test md5Test = new Md5Test()
                    {
                        Id = VMd5test.Id,
                        Key = VMd5test.Key,
                        Value = VMd5test.Value
                    }; UpdateMD5(md5Test);
                    break;
                case 1:
                    Md5Test1 md5Test1 = new Md5Test1(){
                        Id = VMd5test.Id,
                        Key = VMd5test.Key,
                        Value = VMd5test.Value
                    };UpdateMD5(md5Test1);
                    break;
                case 2:
                    Md5Test2 md5Test2 = new Md5Test2()
                    {
                        Id = VMd5test.Id,
                        Key = VMd5test.Key,
                        Value = VMd5test.Value
                    }; UpdateMD5(md5Test2);
                    break;
                case 3:
                    Md5Test3 md5Test3 = new Md5Test3()
                    {
                        Id = VMd5test.Id,
                        Key = VMd5test.Key,
                        Value = VMd5test.Value
                    }; UpdateMD5(md5Test3);
                    break;
                case 4:
                    Md5Test4 md5Test4 = new Md5Test4()
                    {
                        Id = VMd5test.Id,
                        Key = VMd5test.Key,
                        Value = VMd5test.Value
                    }; UpdateMD5(md5Test4);
                    break;
                default:
                    break;
            }
            
            return RedirectToPage("./Index");
        }

        public async void UpdateMD5<T>(T md5Test)
        {
            _context.Attach(md5Test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VMd5testExists(VMd5test.Id))
                {
                    //return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        private bool VMd5testExists(int id)
        {
            return _context.VMd5test.Any(e => e.Id == id);
        }
    }
}
