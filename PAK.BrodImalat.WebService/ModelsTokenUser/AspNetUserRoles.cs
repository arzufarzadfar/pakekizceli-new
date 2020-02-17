using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.ModelsTokenUser
{
    public partial class AspNetUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles Role { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
