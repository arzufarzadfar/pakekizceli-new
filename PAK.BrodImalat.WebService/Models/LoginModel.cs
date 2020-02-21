using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class LoginModel
    {

        //[Required(ErrorMessage = "khaliyeeeeeee")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "khaliyeeeeeee")]

        public string Password { get; set; }



    }
}
