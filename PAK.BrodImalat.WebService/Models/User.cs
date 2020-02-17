using PAK.BrodImalat.WebService.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class User : BaseEntity
    {
       
        
        public int Id { get; set; }
        public string Name { get; set; }


        public string Email { get; set; }

        public string Password { get; set; }
        public bool Active { get; set; } = true;

        //public List<Order> orders { get; set; }
    }
}
