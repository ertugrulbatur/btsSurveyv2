using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class Choice : BaseEntity
    {
        [Column(TypeName = "varchar(70)")]
        public string Text { get; set; }
        /// <summary>
        /// Choice's Question Id
        /// </summary>
        [ForeignKey("Question")]
        public Guid QId { get; set; }
        public Question Question { get; set; }
        public DateTime dateTime { get; set; }
        public double TimeStamp { get; set; }
    }
}
