using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Concrete_ASY : AbstractFactory_Kafedras
    {
        public override AbstractLecture CreateLecture()
        {
            return new Lecture_ASY();
        }

        public override AbstractPractic CreatePractic()
        {
            return new Practic_ASY();
        }

        public override AbstractSeminar CreateSeminar()
        {
            return new Seminar_ASY();
        }
    }
}
