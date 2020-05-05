using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_authentication.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public DateTime CareerStarted { get; set; }
    }
}