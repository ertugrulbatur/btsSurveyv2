using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Hatalı Kullancı Adı veya Şifre")]
        [UIHint("User Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Hatalı Kullancı Adı veya Şifre")]
        [UIHint("Password")]
        public string Password { get; set; }
    }
}
