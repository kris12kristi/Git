using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Lecture_CAPR : AbstractLecture
    {
        public override void Interact(AbstractLecture lecture)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name +"\tТеоретичні основи САПР, Лекція 1");
            Console.WriteLine(this.GetType().Name + "\tМатематичне моделювання, Лекція 2");
            Console.WriteLine(this.GetType().Name + "\tКомпютерне моделювання, Лекція 3");
            Console.WriteLine(this.GetType().Name + "\tТехнології створення ПП, Лекція 4");
            Console.WriteLine(this.GetType().Name + "\tТехнології компютерного проектування, Лекція 5");
        }
    }
}
