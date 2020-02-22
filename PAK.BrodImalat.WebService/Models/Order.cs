using PAK.BrodImalat.WebService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class Order : BaseEntity 
    {
        public int Id { get; set; }
       
        public string FicheNo { get; set; }

        public int? statusId { get; set; }


        public Status status { get; set; }


        public int? ClientId { get; set; }

        public Client Client { get; set; }

        //public List<OrderDetail> orderDetails { get; set; }


    }
}
