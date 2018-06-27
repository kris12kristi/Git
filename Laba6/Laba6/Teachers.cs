using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public class Teachers
    {
        public int Teachers_id { get; set; }
        public string Teachers_name { get; set; }
        public int Teachers_age { get; set; }
        public string Teachers_level { get; set; }
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
