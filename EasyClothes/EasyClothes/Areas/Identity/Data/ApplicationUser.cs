using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyClothes.Models;
using Microsoft.AspNetCore.Identity;

namespace EasyClothes.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public string Name { get; set; } = string.Empty;
    [PersonalData]
    public string Surname { get; set; } = string.Empty;
    [PersonalData]
    public string AddressLineOne { get; set; } = string.Empty;
    [PersonalData]
    public string AddressLineTwo { get; set;} = string.Empty;
    [PersonalData]
    public string PostCode { get; set; } = string.Empty;
    public DateTime DateJoined { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
    public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
    public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
    public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
}

