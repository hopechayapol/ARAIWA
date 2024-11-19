<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Areas.Identity.Data;

// Add profile data for application users by adding properties to the FinalProjectUser class
public class FinalProjectUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobilePhone { get; set; }
}

=======
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
>>>>>>> 4f74a9664c41ed36d7ae4fa9effc1d036e3655d9
