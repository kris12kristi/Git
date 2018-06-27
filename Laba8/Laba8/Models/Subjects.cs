using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laba8.Models
{
    public class Subjects
    {
        [Key]
        public int Subject_id { get; set; }
        public string Subject_name { get; set; }
        public int Subject_hour { get; set; }
        public string Subject_Type_Ex { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
        public Subjects()
        {
            Teachers = new List<Teachers>();
        }


    }
}