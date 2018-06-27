using System;

namespace Laba7
{
    class Practic_CAPR : AbstractPractic
    {
        public override void Interact(AbstractPractic practic)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name + "\tТеоретичні основи САПР, Практична 1");
            Console.WriteLine(this.GetType().Name + "\tМатематичне моделювання, Практична 2");
            Console.WriteLine(this.GetType().Name + "\tКомпютерне моделювання, Практична 3");
        }
    }
}