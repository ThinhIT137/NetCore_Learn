using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TDT_Day09_CodeFirst.Models;

namespace TDT_Day09_CodeFirst.Controllers
{
    public class tdtLoai_San_PhamController : Controller
    {
        private readonly tdtDay09AppContext _context;

        public tdtLoai_San_PhamController(tdtDay09AppContext context)
        {
            _context = context;
        }

        // GET: tdtLoai_San_Pham
        public async Task<IActionResult> tdtIndex()
        {
            return View(await _context.tdtLoai_San_Pham.ToListAsync());
        }

        // GET: tdtLoai_San_Pham/Details/5
        public async Task<IActionResult> tdtDetails(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tdtLoai_San_Pham = await _context.tdtLoai_San_Pham
                .FirstOrDefaultAsync(m => m.tdtId == id);
            if (tdtLoai_San_Pham == null)
            {
                return NotFound();
            }

            return View(tdtLoai_San_Pham);
        }

        // GET: tdtLoai_San_Pham/Create
        public IActionResult tdtCreate()
        {
            return View();
        }

        // POST: tdtLoai_San_Pham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> tdtCreate([Bind("tdtId,tdtMaLoai,tdtTenLoai,tdtTrangThai")] tdtLoai_San_Pham tdtLoai_San_Pham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tdtLoai_San_Pham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(tdtIndex));
            }
            return View(tdtLoai_San_Pham);
        }

        // GET: tdtLoai_San_Pham/Edit/5
        public async Task<IActionResult> tdtEdit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tdtLoai_San_Pham = await _context.tdtLoai_San_Pham.FindAsync(id);
            if (tdtLoai_San_Pham == null)
            {
                return NotFound();
            }
            return View(tdtLoai_San_Pham);
        }

        // POST: tdtLoai_San_Pham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> tdtEdit(long id, [Bind("tdtId,tdtMaLoai,tdtTenLoai,tdtTrangThai")] tdtLoai_San_Pham tdtLoai_San_Pham)
        {
            if (id != tdtLoai_San_Pham.tdtId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tdtLoai_San_Pham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tdtLoai_San_PhamExists(tdtLoai_San_Pham.tdtId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(tdtIndex));
            }
            return View(tdtLoai_San_Pham);
        }

        // GET: tdtLoai_San_Pham/Delete/5
        public async Task<IActionResult> tdtDelete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tdtLoai_San_Pham = await _context.tdtLoai_San_Pham
                .FirstOrDefaultAsync(m => m.tdtId == id);
            if (tdtLoai_San_Pham == null)
            {
                return NotFound();
            }

            return View(tdtLoai_San_Pham);
        }

        // POST: tdtLoai_San_Pham/Delete/5
        [HttpPost, ActionName("tdtDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> tdtDeleteConfirmed(long id)
        {
            var tdtLoai_San_Pham = await _context.tdtLoai_San_Pham.FindAsync(id);
            if (tdtLoai_San_Pham != null)
            {
                _context.tdtLoai_San_Pham.Remove(tdtLoai_San_Pham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(tdtIndex));
        }

        private bool tdtLoai_San_PhamExists(long id)
        {
            return _context.tdtLoai_San_Pham.Any(e => e.tdtId == id);
        }
    }
}
