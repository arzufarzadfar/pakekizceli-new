using PAK.BrodImalat.WebService.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class OrderDetail : BaseEntity
    {
       
        public int Id { get; set; }

        public int?  OrderId { get; set; }
        public Order Order { get; set; }


        public double?  Amount { get; set; }


       

        public int? AltUnitId { get; set; }
        public AltUnit AltUnit { get; set; }


        public int? ItemId { get; set; }
        public Item Item { get; set; }


    }
}
