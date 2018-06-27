using System;

namespace Laba7
{
    class Practic_ISM : AbstractPractic
    {
        public override void Interact(AbstractPractic practic)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name + "\tКомпютерні мережі, Практична 1");
            Console.WriteLine(this.GetType().Name + "\tКомпютерні мережі, Практична 2");
            Console.WriteLine(this.GetType().Name + "\tКомпютерні мережі, Практична 3");
            Console.WriteLine(this.GetType().Name + "\tКомпютерні мережі, Практична 4");
            Console.WriteLine(this.GetType().Name + "\tКомпютерні мережі, Практична 5");
        }
    }
}