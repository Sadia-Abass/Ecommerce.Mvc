using Microsoft.AspNetCore.Identity;

namespace EasyClothes.Areas.Identity.Data
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string Description { get; set; } = string.Empty;
    }
}
