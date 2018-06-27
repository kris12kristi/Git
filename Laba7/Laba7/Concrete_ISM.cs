using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Concrete_ISM : AbstractFactory_Kafedras
    {
        public override AbstractLecture CreateLecture()
        {
            return new Lecture_ISM();
        }

        public override AbstractPractic CreatePractic()
        {
            return new Practic_ISM();
        }

        public override AbstractSeminar CreateSeminar()
        {
            return new Seminar_ISM();
        }
    }
}
