using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laba8.Models
{
    public class Instutyt
    {   [Key]
        public int Instytyts_id { get; set; }
        public string Instytyts_name { get; set; }
        public string Director { get; set; }

    }
}