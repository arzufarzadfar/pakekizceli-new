using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
       
        public DateTime? LogicCreatedDate { get; set; }
        public DateTime? LogicModifiedDate { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Floor { get; set; }
        public string Rope { get; set; }
        public string Pattern { get; set; }
        public string Strike{ get; set; }
        //public List<OrderDetail> orderDetails { get; set; }

    }
}
