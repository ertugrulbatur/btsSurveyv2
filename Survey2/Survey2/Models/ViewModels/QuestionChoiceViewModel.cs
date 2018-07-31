using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models.ViewModels
{
    public class QuestionChoiceViewModel
    {
        public Choice Choice { get; set; }
        public Question Question { get; set; }
    }
}
