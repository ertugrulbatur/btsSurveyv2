using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [UIHint("Password")]
        public string Password { get; set; }
        public string Department { get; set; }
        //[Required]
        //public string Email { get; set; }
    }
}
