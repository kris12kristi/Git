using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public class Subjects
    {
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
