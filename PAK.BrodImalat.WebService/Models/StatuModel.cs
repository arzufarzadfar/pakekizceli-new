using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class StatuModel
    {

        public int Id { get; set; }

        [Required]
        public int Statu { get; set; }

    }
}
