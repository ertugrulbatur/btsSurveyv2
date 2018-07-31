using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class Annoucement : BaseEntity
    {
        
        public string Text { get; set; }
        /// <summary>
        /// Annoucement's User Id
        /// </summary>
        [ForeignKey("AppUser")]
        public string UID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
