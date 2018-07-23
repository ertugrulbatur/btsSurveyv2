using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class Answer : BaseEntity
    {
        public Guid QuestionId { get; set; }
        public string Question { get; set; }
        public Guid SurveyId { get; set; }        
        public string Choice { get; set; }
        /// <summary>
        /// Answer's User Id
        /// </summary>
        [ForeignKey("AppUser")]
        public string UID { get; set; }

        public AppUser AppUser { get; set; }

    }
}
