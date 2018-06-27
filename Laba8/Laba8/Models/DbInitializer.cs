using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Laba8.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<LabContext>
    {
        protected override void Seed(LabContext db)
        {
            db.Instutyts.Add(new Instutyt { Instytyts_id = 1, Instytyts_name = "ІКНІ", Director = "Медиковський" });
            db.Instutyts.Add(new Instutyt { Instytyts_id = 2, Instytyts_name = "ІКТА", Director = "Світлик" });
            db.Instutyts.Add(new Instutyt { Instytyts_id = 3, Instytyts_name = "ІНЕМ", Director = "Зоряний" });
            db.Instutyts.Add(new Instutyt { Instytyts_id = 4, Instytyts_name = "ІТРЕ", Director = "Дворян" });


            db.Kafedras.Add(new Kafedra
            {Kafedra_id = 1, Kafedra_name = "САПР", Kafedra_zav = "Лобур", Count_Doctor_Science = 7, Instytyts_id = 1});

            db.Kafedras.Add(new Kafedra
            { Kafedra_id = 2, Kafedra_name = "ІСМ", Kafedra_zav = "Литвин", Count_Doctor_Science = 3, Instytyts_id = 1 });

            db.Kafedras.Add(new Kafedra
            { Kafedra_id = 3, Kafedra_name = "АСУ", Kafedra_zav = "Дворян", Count_Doctor_Science = 1, Instytyts_id = 2 });

            db.Kafedras.Add(new Kafedra
            { Kafedra_id = 4, Kafedra_name = "СШІ", Kafedra_zav = "Кривий", Count_Doctor_Science = 3, Instytyts_id = 4 });

            db.Teacher.Add(new Teachers
            {   Teachers_id = 1,
                Teachers_name = "Лобур",
                Teachers_age = 45,
                Teachers_level = "Професор",
                Teachers_phone = "097453622",
                Kafedra_id = 1
            });

            db.Teacher.Add(new Teachers
            {
                Teachers_id = 1,
                Teachers_name = "Лобур",
                Teachers_age = 45,
                Teachers_level = "Професор",
                Teachers_phone = "097453622",
                Kafedra_id = 1
            });

            db.Teacher.Add(new Teachers
            {
                Teachers_id = 2,
                Teachers_name = "Тимощук",
                Teachers_age = 45,
                Teachers_level = "Професор",
                Teachers_phone = "093453622",
                Kafedra_id = 1
            });


            db.Teacher.Add(new Teachers
            {
                Teachers_id = 3,
                Teachers_name = "Теслюк",
                Teachers_age = 45,
                Teachers_level = "Професор",
                Teachers_phone = "095443622",
                Kafedra_id = 1
            });


            db.Teacher.Add(new Teachers
            {
                Teachers_id = 4,
                Teachers_name = "Денисюк",
                Teachers_age = 30,
                Teachers_level = "Доцент",
                Teachers_phone = "093453622",
                Kafedra_id = 1
            });

            db.Subject.Add(new Subjects
            {Subject_id = 1, Subject_name = "ТО САПР", Subject_hour = 150, Subject_Type_Ex = "екзамен"});

            db.Subject.Add(new Subjects
            { Subject_id = 2, Subject_name = "Моделювання систем", Subject_hour = 150, Subject_Type_Ex = "залік" });

            db.Subject.Add(new Subjects
            { Subject_id = 3, Subject_name = "English", Subject_hour = 120, Subject_Type_Ex = "залік" });

            db.Subject.Add(new Subjects
            { Subject_id = 4, Subject_name = "Компютерне проектування", Subject_hour = 190, Subject_Type_Ex = "екзамен" });


            base.Seed(db);
        }

    }
  
}