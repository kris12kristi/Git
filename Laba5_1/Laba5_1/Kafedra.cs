using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Laba5_1
{
   public class Kafedra
    {   [Key]
        public int Kafedra_id { get; set; }

       [MinLength(4)]
       [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Kafedra_name { get; set; }

       [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Kafedra_zav { get; set; }
        public int Count_Doctor_Science { get; set; }

        //foreign key
        public int Instytyts_id { get; set; }
    }
}
