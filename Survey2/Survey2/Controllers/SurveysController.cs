using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Survey2.Data;
using Survey2.Models;
using Survey2.Models.ViewModels;

namespace Survey2.Controllers
{
    [Authorize(Roles = "Admin")]
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
            
             //var sModel = _context.Survey.Join(_context.Question,
             //       sur => sur.Id,
             //       quest => quest.SID,                    
             //       (sur, quest) => new SurveyViewModel()
             //       {
             //           QCVm = _context.Question.Where(x => x.SID == quest.SID).ToList(),
             //           Survey = _context.Survey.Where(x => x.Id == quest.SID).FirstOrDefault(),
             //           Choice = _context.Choice.Where(x => x.QId == quest.Id).ToList()
             //       }
             //   ).Where(x=> x.Survey.Id == id).FirstOrDefault();

            Survey S1 = _context.Survey.Where(x => x.Id == id).Include(x => x.Questions).ThenInclude(x => x.Choices).FirstOrDefault();

            return View(S1);
        }
        [HttpGet]
        public IActionResult AddQuestion()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddQuestion([Bind("Text,SID,UID,Id")] Guid Id, Question question)
        {
            if (ModelState.IsValid || question.Text != null)
            {
           
                question.dateTime = DateTime.Now;
                question.TimeStamp = double.Parse(question.dateTime.ToString("yyyyMMddhhmmss"));
                question.SID = Id;                  
                question.Id = Guid.NewGuid();                 
                question.UID = _context.Survey.Where(x => x.Id == Id).FirstOrDefault().UID;
                //question.Type = 

                //question.TimeStamp = double.Parse(question.dateTime.ToString("yyyyMMddhhmmss"));                
                _context.Question.Add(question);
                
                await _context.SaveChangesAsync();
                return RedirectToAction("AddChoice", question);                
            }            
            //ViewData["UID"] = new SelectList(_context.AppUser, "Id", "UserName", question.UID);
            //ViewData["SID"] = new SelectList(_context.Survey, "Id", "Text", question.SID);
            return View();
        }

        [HttpGet]
        public IActionResult AddChoice(Question question)
        {
            ChoiceIdViewModel choiceidviewmodel = new ChoiceIdViewModel();
            choiceidviewmodel.QuestId = question.Id;
            choiceidviewmodel.QuestionText = question.Text;
            choiceidviewmodel.QuestionType = question.Type;
            //Guid guid = new Guid();
            //guid = question.Id;
            return View(choiceidviewmodel);
        }
        [HttpPost]
        public IActionResult AddChoice(string choicetext, string questionid, string questionType)
        {
            if (ModelState.IsValid && choicetext != null)
            {
                Choice choice = new Choice();
                choice.dateTime = DateTime.Now;
                choice.Id = Guid.NewGuid();
                choice.TimeStamp = double.Parse(choice.dateTime.ToString("yyyyMMddhhmmss"));
                choice.QId = new Guid(questionid);
                choice.Text = choicetext;
                choice.Type = questionType;
                //choice.UID = _context.Survey.Where(x => x.Id == Id).FirstOrDefault().UID;
                //choiceidviewmodel.QuestId = choiceidviewmodel.Choice.QId;

                _context.Add(choice);
                _context.SaveChanges();
                var AllQuestionChoices = _context.Choice.Where(a => a.QId == new Guid(questionid)).Select(a => a.Text).ToList();
                return Json(choicetext);
            }           

            return View();
        }        
    }
}
