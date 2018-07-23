using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class AppUser : IdentityUser
    {
        //public override string Id { get => base.Id; set => base.Id = value; }
        //public string Name { get; set; }
        //public string Role { get; set; }
        //public string Password { get; set; }

        public ICollection<Complaint> Complaints { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<Survey> Surveys { get; set; }
        public ICollection<Annoucement> Annoucements { get; set; }
    }
}
