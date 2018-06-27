using System;

namespace Laba7
{
    class Lecture_ISM : AbstractLecture
    {
        public override void Interact(AbstractLecture lecture)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name + "\tКомпютерні мережі");
            Console.WriteLine(this.GetType().Name + "\tПрограмування С#");
            Console.WriteLine(this.GetType().Name + "\tПрограмування С++");
        }
    }
}