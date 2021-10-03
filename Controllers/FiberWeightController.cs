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
    public class FiberWeightController : Controller
    {
        private readonly StashMashContext _context;

        public FiberWeightController(StashMashContext context)
        {
            _context = context;
        }

        // GET: FiberWeight
        public async Task<IActionResult> Index()
        {
            return View(await _context.FiberWeights.ToListAsync());
        }

        // GET: FiberWeight/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fiberWeight = await _context.FiberWeights
                .FirstOrDefaultAsync(m => m.FiberWeightId == id);
            if (fiberWeight == null)
            {
                return NotFound();
            }

            return View(fiberWeight);
        }

        // GET: FiberWeight/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FiberWeight/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FiberWeightId,Symbol,Name")] FiberWeight fiberWeight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fiberWeight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fiberWeight);
        }

        // GET: FiberWeight/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fiberWeight = await _context.FiberWeights.FindAsync(id);
            if (fiberWeight == null)
            {
                return NotFound();
            }
            return View(fiberWeight);
        }

        // POST: FiberWeight/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FiberWeightId,Symbol,Name")] FiberWeight fiberWeight)
        {
            if (id != fiberWeight.FiberWeightId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fiberWeight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FiberWeightExists(fiberWeight.FiberWeightId))
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
            return View(fiberWeight);
        }

        // GET: FiberWeight/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fiberWeight = await _context.FiberWeights
                .FirstOrDefaultAsync(m => m.FiberWeightId == id);
            if (fiberWeight == null)
            {
                return NotFound();
            }

            return View(fiberWeight);
        }

        // POST: FiberWeight/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fiberWeight = await _context.FiberWeights.FindAsync(id);
            _context.FiberWeights.Remove(fiberWeight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FiberWeightExists(int id)
        {
            return _context.FiberWeights.Any(e => e.FiberWeightId == id);
        }
    }
}
