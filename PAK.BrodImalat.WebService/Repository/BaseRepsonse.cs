using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Repository
{
    public class BaseRepsonse
    {
        public List<string> Errors { get; set; }
        public bool HasError { get; set; }
        public bool IsSuccessFul { get; set; }
    }
}
