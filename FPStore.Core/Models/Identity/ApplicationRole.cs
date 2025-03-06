using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStore.Core.Models.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }

        public ApplicationRole() : base()
        {
            UserRoles = new HashSet<ApplicationUserRole>();
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
            UserRoles = new HashSet<ApplicationUserRole>();
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }

    }
}
