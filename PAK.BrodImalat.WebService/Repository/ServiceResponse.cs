using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Repository
{
    public class ServiceResponse<T> : BaseRepsonse
    {
        public T Entity { get; set; }
        public List<T> Entities { get; set; }
        public int EntitiesCount { get; set; }

        public ServiceResponse()

        {
            Errors = new List<string>();
            Entities = new List<T>();

        }
    }
}
