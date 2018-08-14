using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models.ViewModels
{
    public class SurveyAnswerViewModel
    {
        public Survey Survey { get; set; }
        public Answer Answer { get; set; } = new Answer();
        public Guid SurveyId { get; set; }
    }
}
