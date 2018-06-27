using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public class Kafedra
    {
        public int Kafedra_id { get; set; }
        public string Kafedra_name { get; set; }
        public string Kafedra_zav { get; set; }
        public int Count_Doctor_Science { get; set; }

        //foreign key
        public int Instytyts_id { get; set; }
    }

}
