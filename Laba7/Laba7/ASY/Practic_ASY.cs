using System;

namespace Laba7
{
    class Practic_ASY : AbstractPractic
    {
        public override void Interact(AbstractPractic practic)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name + "\tПрактична 1_04.11.2017");
            Console.WriteLine(this.GetType().Name + "\tПрактична 2_05.12.2017");
            Console.WriteLine(this.GetType().Name + "\tПрактична 3_10.01.2018");
            Console.WriteLine(this.GetType().Name + "\tПрактична 4_12.01.2018");
            Console.WriteLine(this.GetType().Name + "\tПрактична 5_15.01.2018");
        }
    }
}