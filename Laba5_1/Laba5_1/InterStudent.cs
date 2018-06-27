using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5_1
{
   public class InterStudent
    {[Key]
        public int id { get; set; }

        [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Student_name { get; set; }
        public int Student_age { get; set; }

        [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Students_ticket { get; set; }


        [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Students_surname { get; set; }

    }
}
