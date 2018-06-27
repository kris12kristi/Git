using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
   abstract class AbstractFactory_Kafedras
    {
    public abstract AbstractLecture CreateLecture();
    public abstract AbstractSeminar CreateSeminar();
    public abstract AbstractPractic CreatePractic();

    }
}
