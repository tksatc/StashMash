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
    public class YarnDetailController : Controller
    {
        private readonly StashMashContext _context;

        public YarnDetailController(StashMashContext context)
        {
            _context = context;
        }

        // GET: YarnDetail
        public async Task<IActionResult> Index()
        {
            var stashMashContext = _context.YarnDetails.Include(y => y.Yarn);
            return View(await stashMashContext.ToListAsync());
        }

        // GET: YarnDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarnDetail = await _context.YarnDetails
                .Include(y => y.Yarn)
                .FirstOrDefaultAsync(m => m.YarnDetailId == id);
            if (yarnDetail == null)
            {
                return NotFound();
            }

            ViewBag.totalYardage = yarnDetail.CalcTotalYardage();
            return View(yarnDetail);
        }

        // GET: YarnDetail/Create
        public IActionResult Create()
        {
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name");
            return View();
        }

        // POST: YarnDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("YarnDetailId,YarnId,YarnColor,YarnColorCode,YarnColorLot,QuantityOfSkeins,DateUpdated")] YarnDetail yarnDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yarnDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name", yarnDetail.YarnId);
            return View(yarnDetail);
        }

        // GET: YarnDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarnDetail = await _context.YarnDetails.FindAsync(id);
            if (yarnDetail == null)
            {
                return NotFound();
            }
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name", yarnDetail.YarnId);
            return View(yarnDetail);
        }

        // POST: YarnDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("YarnDetailId,YarnId,YarnColor,YarnColorCode,YarnColorLot,QuantityOfSkeins,DateUpdated")] YarnDetail yarnDetail)
        {
            if (id != yarnDetail.YarnDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yarnDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YarnDetailExists(yarnDetail.YarnDetailId))
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
            ViewData["YarnId"] = new SelectList(_context.Yarn, "YarnId", "Name", yarnDetail.YarnId);
            return View(yarnDetail);
        }

        // GET: YarnDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yarnDetail = await _context.YarnDetails
                .Include(y => y.Yarn)
                .FirstOrDefaultAsync(m => m.YarnDetailId == id);
            if (yarnDetail == null)
            {
                return NotFound();
            }

            return View(yarnDetail);
        }

        // POST: YarnDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yarnDetail = await _context.YarnDetails.FindAsync(id);
            _context.YarnDetails.Remove(yarnDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YarnDetailExists(int id)
        {
            return _context.YarnDetails.Any(e => e.YarnDetailId == id);
        }
    }
}
