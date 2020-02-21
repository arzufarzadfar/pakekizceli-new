using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string firsName { get; set; }
        public string lastName { get; set; }
    }
}
