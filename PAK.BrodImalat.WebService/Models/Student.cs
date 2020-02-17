using System;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Fam { get; set; }

        public int GropId { get; set; }
        public grop grop { get; set; }



    }



}
