using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnThucTap.Models;

namespace DoAnThucTap.Controllers
{
    public class DaughihinhsController : Controller
    {
        private readonly ADbContext _context;

        public DaughihinhsController(ADbContext context)
        {
            _context = context;
        }

        // GET: Daughihinhs
        public async Task<IActionResult> Index()
        {
              return _context.daughihinhs != null ? 
                          View(await _context.daughihinhs.ToListAsync()) :
                          Problem("Entity set 'ADbContext.Daughihinh'  is null.");
        }

        // GET: Daughihinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.daughihinhs == null)
            {
                return NotFound();
            }

            var daughihinh = await _context.daughihinhs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (daughihinh == null)
            {
                return NotFound();
            }

            return View(daughihinh);
        }

        // GET: Daughihinhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Daughihinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Brand,Resolution,Price,Quantity")] Daughihinh daughihinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(daughihinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(daughihinh);
        }

        // GET: Daughihinhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.daughihinhs == null)
            {
                return NotFound();
            }

            var daughihinh = await _context.daughihinhs.FindAsync(id);
            if (daughihinh == null)
            {
                return NotFound();
            }
            return View(daughihinh);
        }

        // POST: Daughihinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Brand,Resolution,Price,Quantity")] Daughihinh daughihinh)
        {
            if (id != daughihinh.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(daughihinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DaughihinhExists(daughihinh.Id))
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
            return View(daughihinh);
        }

        // GET: Daughihinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.daughihinhs == null)
            {
                return NotFound();
            }

            var daughihinh = await _context.daughihinhs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (daughihinh == null)
            {
                return NotFound();
            }

            return View(daughihinh);
        }

        // POST: Daughihinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.daughihinhs == null)
            {
                return Problem("Entity set 'ADbContext.Daughihinh'  is null.");
            }
            var daughihinh = await _context.daughihinhs.FindAsync(id);
            if (daughihinh != null)
            {
                _context.daughihinhs.Remove(daughihinh);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DaughihinhExists(int id)
        {
          return (_context.daughihinhs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
