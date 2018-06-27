using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laba8.Models
{
    public class Kafedra
    {
        [Key]
        public int Kafedra_id { get; set; }
   
        public string Kafedra_name { get; set; }
 
        public string Kafedra_zav { get; set; }
        public int Count_Doctor_Science { get; set; }
   
        //foreign key
        public int Instytyts_id { get; set; }

    }
}