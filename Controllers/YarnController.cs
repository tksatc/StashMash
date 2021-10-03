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
    public class YarnController : Controller
    {
        private readonly StashMashContext _context;

        public YarnController(StashMashContext context)
        {
            _context = context;
        }

        // GET: Yarn
        public async Task<IActionResult> Index()
        {
            var stashMashContext = _context.Yarn.Include(y => y.Fiber).Include(y => y.FiberWeight).Include(y => y.Manufacturer);
            return View(await stashMashContext.ToListAsync());
        }

        // GET: Yarn/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarn = await _context.Yarn
                .Include(y => y.Fiber)
                .Include(y => y.FiberWeight)
                .Include(y => y.Manufacturer)
                .FirstOrDefaultAsync(m => m.YarnId == id);
            if (yarn == null)
            {
                return NotFound();
            }

            return View(yarn);
        }

        // GET: Yarn/Create
        public IActionResult Create()
        {
            ViewData["FiberId"] = new SelectList(_context.Fibers, "FiberId", "Name");
            ViewData["FiberWeightId"] = new SelectList(_context.FiberWeights, "FiberWeightId", "FiberWeightId");
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name");
            return View();
        }

        // POST: Yarn/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("YarnId,ManufacturerId,Name,FiberId,FiberWeightId,SkeinYardage,SkeinWeight,MeasurementUnit,DateUpdated")] Yarn yarn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yarn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FiberId"] = new SelectList(_context.Fibers, "FiberId", "Name", yarn.FiberId);
            ViewData["FiberWeightId"] = new SelectList(_context.FiberWeights, "FiberWeightId", "FiberWeightId", yarn.FiberWeightId);
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name", yarn.ManufacturerId);
            return View(yarn);
        }

        // GET: Yarn/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarn = await _context.Yarn.FindAsync(id);
            if (yarn == null)
            {
                return NotFound();
            }
            ViewData["FiberId"] = new SelectList(_context.Fibers, "FiberId", "Name", yarn.FiberId);
            ViewData["FiberWeightId"] = new SelectList(_context.FiberWeights, "FiberWeightId", "FiberWeightId", yarn.FiberWeightId);
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name", yarn.ManufacturerId);

            return View(yarn);
        }

        // POST: Yarn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("YarnId,ManufacturerId,Name,FiberId,FiberWeightId,SkeinYardage,SkeinWeight,MeasurementUnit,DateUpdated")] Yarn yarn)
        {
            if (id != yarn.YarnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yarn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YarnExists(yarn.YarnId))
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
            ViewData["FiberId"] = new SelectList(_context.Fibers, "FiberId", "Name", yarn.FiberId);
            ViewData["FiberWeightId"] = new SelectList(_context.FiberWeights, "FiberWeightId", "FiberWeightId", yarn.FiberWeightId);
            ViewData["ManufacturerId"] = new SelectList(_context.Manufacturers, "ManufacturerId", "Name", yarn.ManufacturerId);
            return View(yarn);
        }

        // GET: Yarn/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarn = await _context.Yarn
                .Include(y => y.Fiber)
                .Include(y => y.FiberWeight)
                .Include(y => y.Manufacturer)
                .FirstOrDefaultAsync(m => m.YarnId == id);
            if (yarn == null)
            {
                return NotFound();
            }

            return View(yarn);
        }

        // POST: Yarn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yarn = await _context.Yarn.FindAsync(id);
            _context.Yarn.Remove(yarn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YarnExists(int id)
        {
            return _context.Yarn.Any(e => e.YarnId == id);
        }
    }
}
