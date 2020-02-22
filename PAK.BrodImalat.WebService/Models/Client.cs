using PAK.BrodImalat.WebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class Client : BaseEntity
    {
        public int Id { get; set; }
        public string ClientCode{ get; set; }
        public string Name { get; set; }


        //public List<Order> orders { get; set; }
    }
}
