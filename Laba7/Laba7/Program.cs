using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Program
    {
        public static void Main()
        { Console.OutputEncoding = Encoding.GetEncoding(1251);
            string str;
            Console.WriteLine("Виберiть пункт меню: ");
            Console.WriteLine("1: Кафедра САПР");
            Console.WriteLine("2: Кафедра ІСМ");
            Console.WriteLine("3: Кафедра АСУ");
            Console.WriteLine();
            do
            {
                str = Console.ReadLine();
                
                switch (str)
                {
                    case "1":
                        Console.WriteLine();
                        AbstractFactory_Kafedras abstractFactory = new Concrete_CAPR();
                        Client client = new Client(abstractFactory);
                        client.Run();
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        AbstractFactory_Kafedras abstractFactory1 = new Concrete_ISM();
                        Client client1 = new Client(abstractFactory1);
                        client1.Run();
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        AbstractFactory_Kafedras abstractFactory2 = new Concrete_ASY();
                        Client client2 = new Client(abstractFactory2);
                        client2.Run();
                        Console.WriteLine();
                        break;

                    default:
                          Console.Write("Помилка ");
                          str = Console.ReadLine();
                        break;

                    case "q":
                        return;
                        break;
                }
            }
            while (str != "q");
           
           Console.ReadKey();
           
        }
         
    }
}
    

