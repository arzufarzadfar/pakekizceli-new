using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class BaseEntity
    {
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public int CreateBy { get; set; }
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        public int UpdateBy { get; set; }
    }
}
