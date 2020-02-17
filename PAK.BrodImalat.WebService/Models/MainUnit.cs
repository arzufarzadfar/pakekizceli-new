using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class MainUnit
    {

        public int Id { get; set; }
       
        public string Code { get; set; }
        public string Name { get; set; }

        public DateTime? LogicCreatedDate { get; set; }
        public DateTime? LogicModifiedDate { get; set; }

        public List<AltUnit> altUnits { get; set; }


    }
}
