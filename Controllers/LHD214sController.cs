using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Controllers
{
    public class LHD214sController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LHD214sController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LHD214s
        public async Task<IActionResult> Index()
        {
            return View(await _context.LHD214.ToListAsync());
        }

        // GET: LHD214s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD214 = await _context.LHD214
                .FirstOrDefaultAsync(m => m.LHDID == id);
            if (lHD214 == null)
            {
                return NotFound();
            }

            return View(lHD214);
        }

        // GET: LHD214s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LHD214s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LHDID,LHDName,LHDGender")] LHD214 lHD214)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lHD214);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lHD214);
        }

        // GET: LHD214s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD214 = await _context.LHD214.FindAsync(id);
            if (lHD214 == null)
            {
                return NotFound();
            }
            return View(lHD214);
        }

        // POST: LHD214s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LHDID,LHDName,LHDGender")] LHD214 lHD214)
        {
            if (id != lHD214.LHDID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lHD214);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LHD214Exists(lHD214.LHDID))
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
            return View(lHD214);
        }

        // GET: LHD214s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD214 = await _context.LHD214
                .FirstOrDefaultAsync(m => m.LHDID == id);
            if (lHD214 == null)
            {
                return NotFound();
            }

            return View(lHD214);
        }

        // POST: LHD214s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lHD214 = await _context.LHD214.FindAsync(id);
            _context.LHD214.Remove(lHD214);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LHD214Exists(string id)
        {
            return _context.LHD214.Any(e => e.LHDID == id);
        }
    }
}
