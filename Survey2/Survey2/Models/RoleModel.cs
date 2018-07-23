using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey2.Models
{
    public class RoleDetails
    {
        public IdentityRole Role { get; set; }
        /// <summary>
        /// Role's Members
        /// </summary>
        public IEnumerable<AppUser> Members { get; set; }
        /// <summary>
        /// Members that can be bind to a specific role.
        /// </summary>
        public IEnumerable<AppUser> NonMembers { get; set; }
    }

    public class RoleEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}
