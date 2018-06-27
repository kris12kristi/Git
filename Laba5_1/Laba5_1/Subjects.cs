using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Laba5_1
{
   public class Subjects
    {   [Key]
        public int Subject_id { get; set; }

        [MinLength(2)]
        [MaxLength(30, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Subject_name { get; set; }
        public int Subject_hour { get; set; }

        [MinLength(2)]
        [MaxLength(15, ErrorMessage = "Name length should be less then 25 characters ")]
        public string Subject_Type_Ex { get; set; }

        public ICollection<Teachers> Teachers { get; set; }
        public Subjects()
        {
            Teachers = new List<Teachers>();
        }

        
    }
}
