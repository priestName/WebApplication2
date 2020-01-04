using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("any")]
    [ApiController]
    public class Md5TestController : ControllerBase
    {
        private readonly TestBokerContext _context;
        public static PageModels PageModel = new PageModels();

        public Md5TestController(TestBokerContext context)
        {
            _context = context;
        }

        [HttpGet("Count")]
        public PageModels GetPageContent()
        {
            int Md5TestsCount = _context.Md5Test1.Count();
            PageModel.TableCount = Md5TestsCount;
            PageModel.PageCount = (int)Math.Ceiling((double)Md5TestsCount / 20);
            return PageModel;
        }
        [HttpGet("Page/{PageIndex}")]
        public async Task<ActionResult<IEnumerable<Md5Test1>>> GetMd5TestPage(int PageIndex = 0)
        {
            return await _context.Md5Test1.Skip(PageIndex * PageModel.PageSize).Take(PageModel.PageSize).ToListAsync();
        }
        [HttpGet("GetModel")]
        public async Task<ActionResult<Md5Test1>> GetMd5Test(int Id)
        {
            var md5Test = await _context.Md5Test1.FindAsync(Id);
            if (md5Test == null)
            {
                return NotFound();
            }
            return md5Test;
        }
        [HttpGet("GetMD5/{key}")]
        public async Task<ActionResult<string>> GetMd5Text(string key)
        {
            Md5Test1 md5Test = new Md5Test1();
            try
            {
                md5Test = await _context.Md5Test1.FirstAsync(m => m.Key == key);
            }
            catch (Exception)
            {
            }

            if (md5Test == null)
            {
                return NotFound();
            }
            return md5Test.Value ?? "未收录";
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMd5Test(int id, Md5Test md5Test)
        {
            if (id != md5Test.Id)
            {
                return BadRequest();
            }

            _context.Entry(md5Test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Md5TestExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("insert")]
        public async Task<ActionResult<Md5Test1>> PostMd5Test([FromBody]Md5Test1 md5Test)
        {
            //_context.Md5Test.Add(md5Test);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetMd5Test", new { id = md5Test.Id }, md5Test);
            return await _context.Md5Test1.FirstAsync(m => m.Key == md5Test.Key);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Md5Test>> DeleteMd5Test(int id)
        {
            var md5Test = await _context.Md5Test.FindAsync(id);
            if (md5Test == null)
            {
                return NotFound();
            }

            _context.Md5Test.Remove(md5Test);
            await _context.SaveChangesAsync();

            return md5Test;
        }

        private bool Md5TestExists(int id)
        {
            return _context.Md5Test.Any(e => e.Id == id);
        }
    }
}
