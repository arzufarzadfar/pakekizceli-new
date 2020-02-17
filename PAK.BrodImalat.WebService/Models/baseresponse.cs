using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class Baseresponse
    {

        public List<string> Errors { get; set; }
        public bool HasError { get; set; }
        public bool IsuccessFul { get; set; }
    }
}
