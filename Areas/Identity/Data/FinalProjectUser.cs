﻿using Microsoft.AspNetCore.Identity;

namespace FinalProject.Areas.Identity.Data
{
    public class FinalProjectUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
    }
}