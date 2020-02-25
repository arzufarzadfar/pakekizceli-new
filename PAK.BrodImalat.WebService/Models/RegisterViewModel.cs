using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RequestApiService.Models
{
    public class RegisterViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
         public string userName { get; set; }
        public string Password { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }


    }
}
