using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models.ViewModels
{
    public class AnswerViewModel
    {
        public string QuestionText { get; set; }
        public string ChoiceText { get; set; }
        public string SurveyText { get; set; }
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid SurveyId { get; set; }
    }
}
