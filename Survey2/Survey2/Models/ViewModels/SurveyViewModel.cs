using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models.ViewModels
{
    public class SurveyViewModel
    {
        public List<Question> Question { get; set; } = new List<Question>();
        public List<Choice> Choice { get; set; } = new List<Choice>();
        public Survey Survey { get; set; }
    }
}
