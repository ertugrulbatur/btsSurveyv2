using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
            if (id != null)
            {
                Survey S1 = _context.Survey.Where(x => x.Id == id).Include(x => x.Questions).ThenInclude(x => x.Choices).FirstOrDefault();
                SurveyAnswerViewModel surveyAnswer = new SurveyAnswerViewModel();
                surveyAnswer.Survey = S1;
                //surveyAnswer.Answer.SurveyId = id;
                surveyAnswer.SurveyId = id;
                surveyAnswer.UserId = S1.UID;
                //surveyAnswer.Answer.SurveyId = S1.Id;
                //surveyAnswer.Answer.dateTime = DateTime.Now;
                //surveyAnswer.Answer.Id = Guid.NewGuid();             
                //surveyAnswer.Answer.TimeStamp = double.Parse(surveyAnswer.Answer.dateTime.ToString("yyyyMMddhhmmss"));
                return View(surveyAnswer);
            }
            return View("Index");
        }
        //[HttpPost]
        //public async Task<IActionResult> GetAnswers(SurveyAnswerViewModel surveyAnswer)
        //{
        //    Answer answer = new Answer();
        //    answer.Id = Guid.NewGuid();
        //    answer.dateTime = DateTime.Now;
        //    answer.TimeStamp = double.Parse(surveyAnswer.Answer.dateTime.ToString("yyyyMMddhhmmss"));


        //    _context.Add(answer);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index", "Answers");
        //}
        [HttpPost]
        public async Task<IActionResult> GetAnswers(Guid surveyId, string userId, ICollection<string> _answer)
        {
            //Answer answer = JsonConvert.DeserializeObject<Answer>(_answer);
            Answer answer = new Answer();
            answer.Id = Guid.NewGuid();
           // answer.Choice = _answer;
            answer.dateTime = DateTime.Now;
            answer.TimeStamp = double.Parse(answer.dateTime.ToString("yyyyMMddhhmmss"));
            answer.UID = userId;
            answer.SurveyId = surveyId;


            _context.Add(answer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Answers");
        }
    }
}