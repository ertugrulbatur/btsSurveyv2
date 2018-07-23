using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class Question : BaseEntity
    {
        [Column(TypeName = "varchar(100)")]
        public string Text { get; set; }
        public ICollection<Choice> Choices { get; set; }
        /// <summary>
        /// Question's Survey Id
        /// </summary>
        [ForeignKey("Survey")]
        public Guid SID { get; set; }
        public Survey Survey { get; set; }
        /// <summary>
        /// Question's User Id
        /// </summary>
        [ForeignKey("AppUser")]
        public string UID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
