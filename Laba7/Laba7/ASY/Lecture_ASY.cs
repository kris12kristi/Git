using System;

namespace Laba7
{
    class Lecture_ASY : AbstractLecture
    {
        public override void Interact(AbstractLecture lecture)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name + "\tУправління системами, Лекція 3");
            Console.WriteLine(this.GetType().Name + "\tЕкономіка, Лекція 2");
            Console.WriteLine(this.GetType().Name + "\tАрхітектура компютерів, Лекція 9");
        }
    }
}