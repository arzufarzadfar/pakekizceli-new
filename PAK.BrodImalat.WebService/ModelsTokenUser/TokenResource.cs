using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.ModelsTokenUser
{
    public class TokenResource
    {

        public int Id { get; set; }
        public long Expiration { get; set; }
        public string Token { get; set; }


    }
}
