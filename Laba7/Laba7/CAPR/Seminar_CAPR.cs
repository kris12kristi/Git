using System;

namespace Laba7
{
    class Seminar_CAPR : AbstractSeminar
    {
        public override void Interact(AbstractSeminar seminar)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("\t\tСемінар 1");
            Console.WriteLine("\t\tТема: Основи ТО САПР");
            Console.WriteLine("\t\tЗавдання: Відповідь на 10 запитань");
            Console.WriteLine("\t\tКількість годин: 2 пари");

            Console.WriteLine();
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("\t\tСемінар 2");
            Console.WriteLine("\t\tТема: Компютерне моделювання");
            Console.WriteLine("\t\tЗавдання: Відповісти на 3 запитань");
            Console.WriteLine("\t\tКількість годин: 1 пара");

            Console.WriteLine();
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("\t\tСемінар 3");
            Console.WriteLine("\t\tТема: Технології компютерного проектування");
            Console.WriteLine("\t\tЗавдання: Відповідь на 15 запитань");
            Console.WriteLine("\t\tКількість годин: 4 пари");
        }
    }
}