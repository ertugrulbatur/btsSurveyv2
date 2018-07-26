using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Survey2.Data;
using Survey2.Models;
using Survey2.Models.ViewModels;

namespace Survey2.Controllers
{
    public class SurveysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SurveysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Surveys
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Survey.Include(s => s.AppUser);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> CreateSurvey([Bind("UID,Text")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                survey.Id = Guid.NewGuid();
                _context.Add(survey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "UserName", survey.UID);
            return View(survey);
        }

        // GET: Surveys/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Survey
                .Include(s => s.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }

        // GET: Surveys/Create
        public IActionResult Create()
        {
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "UserName");
            return View();
        }

        // POST: Surveys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UID,Text")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                survey.dateTime = DateTime.Now;
                survey.TimeStamp = double.Parse(survey.dateTime.ToString("yyyyMMddhhmmss"));
                survey.Id = Guid.NewGuid();
                _context.Add(survey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "UserName", survey.UID);
            return View(survey);
        }

        // GET: Surveys/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Survey.FindAsync(id);
            if (survey == null)
            {
                return NotFound();
            }
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "Text", survey.UID);
            return View(survey);
        }

        // POST: Surveys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("UID,Id")] Survey survey)
        {
            if (id != survey.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(survey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurveyExists(survey.Id))
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
            ViewData["UID"] = new SelectList(_context.AppUser, "Id", "Text", survey.UID);
            return View(survey);
        }

        // GET: Surveys/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Survey
                .Include(s => s.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }

        // POST: Surveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var survey = await _context.Survey.FindAsync(id);
            _context.Survey.Remove(survey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurveyExists(Guid id)
        {
            return _context.Survey.Any(e => e.Id == id);
        }

        public IActionResult GetSurveyQuestions(Guid? id)
        {
             var sModel = _context.Survey.Join(_context.Question,
                    sur => sur.Id,
                    quest => quest.SID,
                    (sur, quest) => new SurveyViewModel()
                    {
                        Question = _context.Question.Where(x => x.SID== quest.SID).ToList(),
                        Survey = _context.Survey.Where(x => x.Id == quest.SID).FirstOrDefault(),
                        Choice = _context.Choice.Where(x=>x.QId == quest.Id).ToList()
                    }
                ).Where(x=> x.Survey.Id == id).Single();                

            return View(sModel);
        }
    }
}
