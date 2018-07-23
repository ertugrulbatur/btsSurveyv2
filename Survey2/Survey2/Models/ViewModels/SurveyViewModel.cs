using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models.ViewModels
{
    public class SurveyViewModel
    {
        public Question Question { get; set; }
        public Choice Choice { get; set; }
        public Survey Survey { get; set; }
    }
}
