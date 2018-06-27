using System;

namespace Laba7
{
    class Seminar_ASY : AbstractSeminar
    {
        public override void Interact(AbstractSeminar seminar)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name + "\tУправління системами, Семінар 1");
            Console.WriteLine(this.GetType().Name + "\tЕкономіка, Семінар 2");
            Console.WriteLine(this.GetType().Name + "\tАрхітектура компютерів, Семінар 3");
        }
    }
}