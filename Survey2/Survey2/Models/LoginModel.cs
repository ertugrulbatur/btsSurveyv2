using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class LoginModel
    {
        [Required]
        [UIHint("User Name")]
        public string Name { get; set; }
        [Required]
        [UIHint("Password")]
        public string Password { get; set; }
    }
}
