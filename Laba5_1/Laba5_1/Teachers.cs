using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Laba5_1
{
   public class Teachers
    {   [Key]
        public int Teachers_id { get; set; }

        [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Teachers_name { get; set; }
        public int Teachers_age { get; set; }

        [MinLength(4)]
        [MaxLength(25, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Teachers_level { get; set; }

        [MinLength(4)]
        [MaxLength(20, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Teachers_phone { get; set; }

        //foreign key
        public int Kafedra_id { get; set; }

        public ICollection<Subjects> Subjects { get; set; }
        public Teachers()
        {
            Subjects = new List<Subjects>();
        }

     }
}
