using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Laba5_1
{
    public class Instytyts
    {
        [Key]
        public int Instytyts_id { get; set; }

        [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Instytyts_name { get; set; }

        [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Director { get; set; }
    }
}
