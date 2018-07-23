using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class Survey : BaseEntity
    {

        public ICollection<Question> Questions { get; set; }
        /// <summary>
        /// Survey's User Id
        /// </summary>
        [ForeignKey("AppUser")]
        public string UID { get; set; }
        public AppUser AppUser { get; set; }
        public string Text { get; set; }
    }
}
