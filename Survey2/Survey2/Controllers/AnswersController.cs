using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survey2.Data;
using Survey2.Models;
using Survey2.Models.ViewModels;

namespace Survey2.Controllers
{
    [Authorize]
    public class AnswersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AnswersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Survey.Include(s => s.AppUser);
            return View(await applicationDbContext.ToListAsync());           
        }
        [HttpGet]
        public IActionResult GetAnswers(Guid id)
        {
            Survey S1 = _context.Survey.Where(x => x.Id == id).Include(x => x.Questions).ThenInclude(x => x.Choices).FirstOrDefault();
            SurveyAnswerViewModel surveyAnswer = new SurveyAnswerViewModel();
            surveyAnswer.Survey = S1;
            surveyAnswer.SurveyId = id;
            //surveyAnswer.Answer.dateTime = DateTime.Now;
            //surveyAnswer.Answer.Id = Guid.NewGuid();             
            //surveyAnswer.Answer.TimeStamp = double.Parse(surveyAnswer.Answer.dateTime.ToString("yyyyMMddhhmmss"));
            return View(surveyAnswer);
        }
        [HttpPost]
        public async Task<IActionResult> GetAnswers(SurveyAnswerViewModel surveyAnswer)
        {
            Answer answer = new Answer();
            answer.Id = Guid.NewGuid();
            answer.dateTime = DateTime.Now;
            answer.TimeStamp = double.Parse(surveyAnswer.Answer.dateTime.ToString("yyyyMMddhhmmss"));


            _context.Add(answer);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}