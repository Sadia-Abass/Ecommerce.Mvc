using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
}

