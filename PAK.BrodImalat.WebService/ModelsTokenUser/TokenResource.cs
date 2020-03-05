using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.ModelsTokenUser
{
    public class TokenResource
    {
        [Key]
        public string Id { get; set; }
      
        public string Token { get; set; }
        public int mod { get; set; }
        public DateTime expires { get; set; }
        public string email { get; set; }


    }
}
