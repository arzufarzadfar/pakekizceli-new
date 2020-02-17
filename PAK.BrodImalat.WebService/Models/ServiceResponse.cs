using Newtonsoft.Json;
using PAK.BrodImalat.WebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class ServiceResponse<T> : Baseresponse
    {
        [JsonProperty]
        public T Entity { get; set; }
        [JsonProperty]
        public List<T> Entities { get; set; }

        public ServiceResponse()  ///crop
        {
            Errors = new List<string>();
            Entities = new List<T>();
        }
    }
}
