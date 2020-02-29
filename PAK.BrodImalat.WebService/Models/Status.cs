using PAK.BrodImalat.WebService.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class Status : BaseEntity
    {
       [Key]
        public int Id { get; set; }
        public string StatuName { get; set; }

        public int StatuCode { get; set; }


        ////public List<Order> order { get; set; }




    }
}
