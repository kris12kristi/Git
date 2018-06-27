using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Concrete_CAPR : AbstractFactory_Kafedras
    {
        public override AbstractLecture CreateLecture()
        {
            return new Lecture_CAPR();
        }

        public override AbstractPractic CreatePractic()
        {
           return new Practic_CAPR();
        }

        public override AbstractSeminar CreateSeminar()
        {
            return new Seminar_CAPR();
        }
    }
}
