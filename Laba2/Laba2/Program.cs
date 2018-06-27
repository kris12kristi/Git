using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;


namespace Laba2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);


            string str;
            Console.WriteLine("Виберiть пункт меню: ");
            Console.WriteLine("1: Переглянути список інститутів ");
            Console.WriteLine("2: Переглянути cписок кафедр");
            Console.WriteLine("3: Переглянути список викладачів");
            Console.WriteLine("4: Переглянути список предметів");
            Console.WriteLine("q: Вихiд");
            Console.WriteLine();
            do
            {
                str = Console.ReadLine();

                switch (str)
                {
                    case "1":
                        ShowInstytyts();
                        Console.WriteLine();
                        break;
                  case "2":
                        ShowAllKafedra();
                        Console.WriteLine();
                        break;
                    case "3":
                       ShowTeachers();
                        Console.WriteLine();
                        break;

                    case "4":
                       ShowSubjects();
                        Console.WriteLine();
                        break;
                    
                    default:
                        Console.WriteLine("Помилка ");
                        str = Console.ReadLine();
                        break;

                    case "q":
                        return;
                        break;


                }


            }
            while (str != "q");
        }
        static void ShowInstytyts()
        {
            Console.WriteLine("Інстититути");
            string titlestr = String.Format("| {0,-20} | {1,-15} |", "Назва інституту", "Директор");
            Console.WriteLine(titlestr);

            using (Entities cl = new Entities())
                foreach (Instytyts instytyts in cl.Instytyts)
                {
                    string str = String.Format("| {0,-20} | {1,-15} |"
                  , instytyts.Instytyts_name.ToString()
                  , instytyts.Director.ToString());
                    Console.WriteLine(str);
                }
            Console.WriteLine();
        }

        static void ShowAllKafedra()
        {
            Console.WriteLine("Кафедра");
            string titlestr = String.Format("| {0,-20} | {1,-25} | {2,-40} |"
    , "Назва кафедри"
    , "Зав. кафедри"
    , "К-сть докторів наук");
            Console.WriteLine(titlestr);

            using (Entities ck = new Entities())
                foreach (Kafedra kaf in ck.Kafedra)
                {
                    string str = String.Format("| {0,-20} | {1,-25} | {2,-40} |"
                  , kaf.Kafedra_name.ToString()
                  , kaf.Kafedra_zav.ToString()
                  , kaf.Count_Doctor_Science.ToString());
                    Console.WriteLine(str);

                }

            Console.WriteLine();
        }

        static void ShowTeachers()
        {
            string titlestr = String.Format("| {0,-10} | {1,-5} | {2,-15} | {3,-25} |"
   , "Імя"
   , "Вік"
   , "Номер тел."
   , "Науковий ступінь");

            Console.WriteLine(titlestr);
            using (Entities teach = new Entities())
                foreach (Teachers tch in teach.Teachers)
                {
                    string str = String.Format("| {0,-10} | {1,-5} | {2,-15} | {3,-25} |"
                  , tch.Teachers_name.ToString()
                  , tch.Teachers_age.ToString()
                  , tch.Teachers_phone.ToString()
                  , tch.Teachers_level.ToString());
                    Console.WriteLine(str);

                }
        }


            static void ShowSubjects()
        {
            Console.WriteLine("Предмети");
            string titlestr = String.Format("| {0,-30} | {1,-20} | {2,-25} |"
    , "Предмет"
    , "К-сть годин"
    , "Тип захисту");

            Console.WriteLine(titlestr);
            using (Entities subject = new Entities())
                foreach (Subjects subj in subject.Subjects)
                {

                    string str = String.Format("| {0,-30} | {1,-20} | {2,-25} |"
                   , subj.Subject_name.ToString()
                   , subj.Subject_hour.ToString()
                   , subj.Subject_Type_Ex.ToString());
                    Console.WriteLine(str);
                }
            Console.WriteLine();
        }

      
  
    }
}
