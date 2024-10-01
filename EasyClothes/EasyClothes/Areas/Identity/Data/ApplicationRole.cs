using Microsoft.AspNetCore.Identity;

namespace EasyClothes.Areas.Identity.Data
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
