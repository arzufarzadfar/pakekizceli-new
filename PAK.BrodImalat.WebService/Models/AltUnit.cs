using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class AltUnit
    {
        public int Id { get; set; }

      
        public string Code { get; set; }
        public string Name { get; set; }

       
        public int? MainUnitId { get; set; }
        
        public MainUnit MainUnit { get; set; }

        //public List<OrderDetail> orderDetails { get; set; }

    }
}
