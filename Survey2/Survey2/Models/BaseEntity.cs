using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
    }
}
