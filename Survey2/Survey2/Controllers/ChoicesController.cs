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
    public class ChoicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChoicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Choices
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Choice.Include(c => c.Question);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Choices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choice = await _context.Choice
                .Include(c => c.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (choice == null)
            {
                return NotFound();
            }

            return View(choice);
        }

        // GET: Choices/Create
        public IActionResult Create()
        {
            ViewData["QId"] = new SelectList(_context.Question, "Id", "Text");
            return View();
        }

        // POST: Choices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Text,QId,dateTime,TimeStamp,Id")] Choice choice)
        {
            if (ModelState.IsValid)
            {
                choice.Id = Guid.NewGuid();
                _context.Add(choice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QId"] = new SelectList(_context.Question, "Id", "Text", choice.QId);
            return View(choice);
        }

        // GET: Choices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choice = await _context.Choice.FindAsync(id);
            if (choice == null)
            {
                return NotFound();
            }
            ViewData["QId"] = new SelectList(_context.Question, "Id", "Id", choice.QId);
            return View(choice);
        }

        // POST: Choices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Text,QId,dateTime,TimeStamp,Id")] Choice choice)
        {
            if (id != choice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(choice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChoiceExists(choice.Id))
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
            ViewData["QId"] = new SelectList(_context.Question, "Id", "Id", choice.QId);
            return View(choice);
        }

        // GET: Choices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choice = await _context.Choice
                .Include(c => c.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (choice == null)
            {
                return NotFound();
            }

            return View(choice);
        }

        // POST: Choices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var choice = await _context.Choice.FindAsync(id);
            _context.Choice.Remove(choice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChoiceExists(Guid id)
        {
            return _context.Choice.Any(e => e.Id == id);
        }
    }
}
