using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models.ViewModels
{
    public class ChoiceIdViewModel
    {
        public Choice Choice { get; set; } = new Choice();
        public Guid QuestId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
    }
}
