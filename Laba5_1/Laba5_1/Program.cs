using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Validation;
using static Laba5_1.Program;

namespace Laba5_1
{
    class Program
    {

        static void Main(string[] args)
        { Console.OutputEncoding = Encoding.GetEncoding(1251);

            Console.WriteLine("Lab 5");

            string str;
            Console.WriteLine("Виберiть пункт меню: ");
            Console.WriteLine("1: Створити БД i додати першi данi");
            Console.WriteLine("2: Переглянути список інститутів ");
            Console.WriteLine("3: Переглянути cписок кафедр");
            Console.WriteLine("4: Переглянути список викладачів");
            Console.WriteLine("5: Переглянути список предметів");
            Console.WriteLine("6: Переглянути змiни");
            Console.WriteLine("7: Ініціалізувати нову таблицю");
            Console.WriteLine("q: Вихiд");

            do
            {
                str = Console.ReadLine();

                switch (str)
                {
                    case "1":
                        AddDada();
                        break;

                    case "2":
                        ShowAllInstytyts();
                        break;

                    case "3":
                        ShowAllKaffedra();
                        break;

                    case "4":
                        ShowAllTeachers();
                        break;

                    case "5":
                        ShowAllSubjects();
                        break;

                    case "6":
                        Audit();
                        break;

                    case "7":
                        IntilNewTable();
                        break;

                    default:
                      //  Console.Write("Помилка ");
                     //   str = Console.ReadLine();
                        break;

                    case "q":
                        return;
                        break;
                }
            }
            while (str != "q");

            Console.ReadKey();
        }

        static void IntilNewTable()
        {
            using (var db = new Lab_Context())
            {
                var intstud = new InterStudent { id = 1, Student_name = "Павло", Student_age = 24, Students_ticket = "Bd25635522" };
                var intstud1 = new InterStudent { id = 2, Student_name = "Денис", Student_age = 26, Students_ticket = "Vdd25635d22" };
                var intstud2 = new InterStudent { id = 3, Student_name = "Саша", Student_age = 27, Students_ticket = "Bd2563dsd22" };


                db.InterStudent.AddRange(new List<InterStudent> {intstud,  intstud1, intstud2});
                db.SaveChanges();


                var istud = db.InterStudent;
                foreach (InterStudent inst in istud)
                {
                    string str = String.Format(" {0,-30} | {1,-15} | {1,-15} |"
                      , inst.Student_name.ToString()
                      , inst.Student_age.ToString()
                      , inst.Students_ticket.ToString());
                    Console.WriteLine(str);
                }
                Console.WriteLine();
            }

            }
        

        static void AddDada()
        {
            using (var db = new Lab_Context())
            {   
                //add new rows to table Instytyts
                var inst = new Instytyts { Instytyts_id = 1, Instytyts_name = "IKNI", Director = "Лобур" };
                var inst1 = new Instytyts { Instytyts_id = 2, Instytyts_name = "ІКТА", Director = "Світлик" };
                var inst2 = new Instytyts { Instytyts_id = 3, Instytyts_name = "ІНЕМ", Director = "Зоряний" };
                 var inst3 = new Instytyts { Instytyts_id = 4, Instytyts_name = "ІТРЕ", Director = "Дворян" };

                //add new rows to table Teachers
                var teach = new Teachers { Teachers_id = 1, Teachers_name = "Лобур", Teachers_age = 45, Teachers_level = "Професор", Teachers_phone = "0965554382" };
                var teach1 = new Teachers { Teachers_id = 2, Teachers_name = "Тимощук", Teachers_age = 55, Teachers_level = "Доцент", Teachers_phone = "0965111382" };
                var teach2 = new Teachers { Teachers_id = 3, Teachers_name = "Теслюк", Teachers_age = 40, Teachers_level = "Професор", Teachers_phone = "0975666382" };
                var teach3 = new Teachers { Teachers_id = 4, Teachers_name = "Денисюк", Teachers_age = 30, Teachers_level = "Доцент", Teachers_phone = "0935534382" };

                Subjects subj = new Subjects { Subject_id = 1, Subject_name = "ТО_САПР", Subject_hour = 150, Subject_Type_Ex = "залік" };
                subj.Teachers.Add(teach);
                Subjects subj1 = new Subjects { Subject_id = 2, Subject_name = "Моделювання", Subject_hour = 120, Subject_Type_Ex = "екзамен" };
                subj1.Teachers.Add(teach2);
                Subjects subj2 = new Subjects { Subject_id = 3, Subject_name = "Системний", Subject_hour = 90, Subject_Type_Ex = "екзамен" };
                subj2.Teachers.Add(teach1);
                Subjects subj3 = new Subjects { Subject_id = 4, Subject_name = "Технології", Subject_hour = 120, Subject_Type_Ex = "залік" };
                subj3.Teachers.Add(teach2);
                Subjects subj4 = new Subjects { Subject_id = 5, Subject_name = "English", Subject_hour = 150, Subject_Type_Ex = "екзамен" };
                subj4.Teachers.Add(teach3);

                Kafedra kaf = new Kafedra { Kafedra_id = 1, Kafedra_name = "САПР", Kafedra_zav = "Лобур", Count_Doctor_Science = 7 };
                Kafedra kaf1 = new Kafedra { Kafedra_id = 2, Kafedra_name = "ІСМq", Kafedra_zav = "Литвин", Count_Doctor_Science = 5 };
                Kafedra kaf2 = new Kafedra { Kafedra_id = 3, Kafedra_name = "АСqУ", Kafedra_zav = "Дворян", Count_Doctor_Science = 6 };
                Kafedra kaf3 = new Kafedra { Kafedra_id = 4, Kafedra_name = "ПqqЗ", Kafedra_zav = "Мастер", Count_Doctor_Science = 7 };
                Kafedra kaf4 = new Kafedra { Kafedra_id = 5, Kafedra_name = "СШІq", Kafedra_zav = "Рибалко", Count_Doctor_Science = 2 };

            

                db.Instytyts.AddRange(new List<Instytyts> { inst, inst1, inst2, inst3 });
                db.Teachers.AddRange(new List<Teachers> { teach, teach1, teach2, teach3 });
                db.Subjects.AddRange(new List<Subjects> { subj, subj1, subj2, subj3, subj4 });
                db.Kafedra.AddRange(new List<Kafedra> { kaf, kaf1, kaf2, kaf3, kaf4 });

                db.SaveChanges();

                Console.WriteLine("Saved entities to the database, press any key to exit.");

                Console.ReadKey();

            }
        }

        static void ShowAllInstytyts()
        {//Method of Instytyts
            Console.WriteLine("Інстититути");
            string titlestr = String.Format(" {0,-30} | {1,-15} |", "Назва інституту", "Директор");
            Console.WriteLine(titlestr);

            using (var db = new Lab_Context())
            {
                var instyt = db.Instytyts;
                foreach (Instytyts inst in instyt)
                {
                    string str = String.Format(" {0,-30} | {1,-15} |"
                      , inst.Instytyts_name.ToString()
                      , inst.Director.ToString());
                    Console.WriteLine(str);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void ShowAllTeachers()
        {
            Console.WriteLine("Викладачі");
            string titlestr = String.Format("| {0,-10} | {1,-5} | {2,-15} | {3,-25} |", "Імя", "Вік", "Номер тел.", "Науковий ступінь");
            Console.WriteLine(titlestr);

            using (var db = new Lab_Context())
            {
                var Tech = db.Teachers;
                foreach (Teachers techs in Tech)
                {
                    string str = String.Format("| {0,-10} | {1,-5} | {2,-15} | {3,-25} "
                      , techs.Teachers_name.ToString()
                     , techs.Teachers_age.ToString()
                     , techs.Teachers_level.ToString()
                     , techs.Teachers_phone.ToString());
                    Console.WriteLine(str);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        static void ShowAllSubjects()
        {
            Console.WriteLine("Предмети");
            string titlestr = String.Format("| {0,-30} | {1,-20} | {2,-25} |", "Предмет", "К-сть годин", "Тип захисту");
            Console.WriteLine(titlestr);

            using (var db = new Lab_Context())
            {
                var Sub = db.Subjects;
                foreach (Subjects subjs in Sub)
                {
                    string str = String.Format("| {0,-30} | {1,-20} | {2,-25} |"
                     , subjs.Subject_name.ToString()
                     , subjs.Subject_hour.ToString()
                     , subjs.Subject_Type_Ex.ToString());
                    Console.WriteLine(str);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void ShowAllKaffedra()
        {
            Console.WriteLine("Предмети");
            string titlestr = String.Format("| {0,-20} | {1,-25} | {2,-40} |", "Назва кафедри", "Зав. кафедри", "К-сть докторів наук");
            Console.WriteLine(titlestr);

            using (var db = new Lab_Context())
            {
                var Kaf = db.Kafedra;
                foreach (Kafedra kaf in Kaf)
                {
                    string str = String.Format("| {0,-20} | {1,-25} | {2,-40} |"
                     , kaf.Kafedra_name.ToString()
                     , kaf.Kafedra_zav.ToString()
                     , kaf.Count_Doctor_Science.ToString());
                    Console.WriteLine(str);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void Audit()
        {
            using (var db = new Lab_Context())
            {
                var instyt = db.Instytyts.Find(1);

                // Change value directly in the DB
                using (var contextDB = new Lab_Context())
                {
                    contextDB.Database.ExecuteSqlCommand("UPDATE Instytyts SET Instytyts_name = Instytyts_name + 'Laba5.Lab_Context' WHERE Instytyts_name = 'IKNI'");
                }

                // Change the current value in memory
                instyt.Instytyts_name ="IKNI";

                string value = db.Entry(instyt).Property(m => m.Instytyts_name).OriginalValue;
                Console.WriteLine(string.Format("Original Value : {0}", value.Replace("Laba5.Lab_Context",null)));

                value = db.Entry(instyt).Property(m => m.Instytyts_name).CurrentValue;
                Console.WriteLine(string.Format("Current Value : {0}", value.ToString() ));

                value = db.Entry(instyt).GetDatabaseValues().GetValue<string>("Instytyts_name");
                Console.WriteLine(string.Format("DB Value : {0}", value.Replace("Laba5.Lab_Context", null)));

                Console.ReadKey();

            }
        }

    }
}

