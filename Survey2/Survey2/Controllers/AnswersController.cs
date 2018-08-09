using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Survey2.Controllers
{
    public class AnswersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAnswers()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> GetAnswers()
        //{

        //}
    }
}