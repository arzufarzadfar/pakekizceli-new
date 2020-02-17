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
        public string Name { get; set; }


        




    }
}
