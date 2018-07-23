using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Survey2.Data;
using Survey2.Models;

namespace Survey2.Controllers
{
    public class AnnoucementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnnoucementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Annoucements
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Annoucement.Include(a => a.AppUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Annoucements/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annoucement = await _context.Annoucement
                .Include(a => a.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (annoucement == null)
            {
                return NotFound();
            }

            return View(annoucement);
        }

        // GET: Annoucements/Create
        public IActionResult Create()
        {
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "Id");
            return View();
        }

        // POST: Annoucements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Text,UID,Id")] Annoucement annoucement)
        {
            if (ModelState.IsValid)
            {
                annoucement.Id = Guid.NewGuid();
                _context.Add(annoucement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "Id", annoucement.UID);
            return View(annoucement);
        }

        // GET: Annoucements/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annoucement = await _context.Annoucement.FindAsync(id);
            if (annoucement == null)
            {
                return NotFound();
            }
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "Id", annoucement.UID);
            return View(annoucement);
        }

        // POST: Annoucements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Text,UID,Id")] Annoucement annoucement)
        {
            if (id != annoucement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(annoucement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnnoucementExists(annoucement.Id))
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
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "Id", annoucement.UID);
            return View(annoucement);
        }

        // GET: Annoucements/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annoucement = await _context.Annoucement
                .Include(a => a.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (annoucement == null)
            {
                return NotFound();
            }

            return View(annoucement);
        }

        // POST: Annoucements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var annoucement = await _context.Annoucement.FindAsync(id);
            _context.Annoucement.Remove(annoucement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnnoucementExists(Guid id)
        {
            return _context.Annoucement.Any(e => e.Id == id);
        }
    }
}
