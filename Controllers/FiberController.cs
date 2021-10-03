using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StashMash.Models;

namespace StashMash.Controllers
{
    public class FiberController : Controller
    {
        private readonly StashMashContext _context;

        public FiberController(StashMashContext context)
        {
            _context = context;
        }

        // GET: Fiber
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fibers.ToListAsync());
        }

        // GET: Fiber/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fiber = await _context.Fibers
                .FirstOrDefaultAsync(m => m.FiberId == id);
            if (fiber == null)
            {
                return NotFound();
            }

            return View(fiber);
        }

        // GET: Fiber/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fiber/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FiberId,Name")] Fiber fiber)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fiber);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fiber);
        }

        // GET: Fiber/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fiber = await _context.Fibers.FindAsync(id);
            if (fiber == null)
            {
                return NotFound();
            }
            return View(fiber);
        }

        // POST: Fiber/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FiberId,Name")] Fiber fiber)
        {
            if (id != fiber.FiberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fiber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FiberExists(fiber.FiberId))
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
            return View(fiber);
        }

        // GET: Fiber/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fiber = await _context.Fibers
                .FirstOrDefaultAsync(m => m.FiberId == id);
            if (fiber == null)
            {
                return NotFound();
            }

            return View(fiber);
        }

        // POST: Fiber/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fiber = await _context.Fibers.FindAsync(id);
            _context.Fibers.Remove(fiber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FiberExists(int id)
        {
            return _context.Fibers.Any(e => e.FiberId == id);
        }
    }
}
