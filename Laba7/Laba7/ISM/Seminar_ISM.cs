using System;

namespace Laba7
{
    class Seminar_ISM : AbstractSeminar
    {
        public override void Interact(AbstractSeminar seminar)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name + "\tКомпютерні мережі, Семінар 1");
            Console.WriteLine(this.GetType().Name + "\tПрограмування С#, Семінар 1");
            Console.WriteLine(this.GetType().Name + "\tПрограмування С++, Семінар 2");
        }
    }
}