using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Laba4
{
    class Program
    {
        static string ReturnUrl()
        {
            string url = "";
            url += @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Rusnak_laba2.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework&quot;";
            return url;
        }
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
                        ReadInstytytsDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine("Зміна даних в таблиці Інститути:");
                        UpAddDelInstytytsDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine("Результуюча таблиця:");
                        ReadInstytytsDbCommand(ReturnUrl());

                        Console.WriteLine();
                        break;
                    case "2":
                        ReadKafedraDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine("Зміна даних в таблиці Кафедра:");
                        UpAddDelKafedraDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine("Результуюча таблиця:");
                        ReadKafedraDbCommand(ReturnUrl());

                        Console.WriteLine();
                        break;
                    case "3":
                        ReadTeachersDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine("Зміна даних в таблиці Викладачі:");
                        UpAddDelTeachersDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine("Результуюча таблиця:");
                        ReadTeachersDbCommand(ReturnUrl());

                        Console.WriteLine();
                        break;

                    case "4":
                        UpAddDeTeachers_SubjectDbCommand(ReturnUrl());

                        ReadSubjectsDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Зміна даних в таблиці Предмети:");
                        UpAddDeiSubjectsDbCommand(ReturnUrl());

                        Console.WriteLine();
                        Console.WriteLine("Результуюча таблиця:");
                        ReadSubjectsDbCommand(ReturnUrl());

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


        //Method of Instytyts
        static void ReadInstytytsDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Instytyts";
                connection.Open();
                DbDataReader rdr = cmd.ExecuteReader();

                string titlestr = String.Format("| {0,-50} | {1,-15} |", "Назва інституту", "Директор");
                Console.WriteLine(titlestr);
                while (rdr.Read())
                {
                    string str = String.Format("| {0,-50} | {1,-15} |", rdr["Instytyts_name"].ToString(), rdr["Director"].ToString());
                    Console.WriteLine(str);
                }
                connection.Close();
            }

        }

        static void UpAddDelInstytytsDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Instytyts";
                var da = new SqlDataAdapter(cmd);
                var nwSet = new DataSet("Rusnak_laba2");
                var bldr = new SqlCommandBuilder(da);
                da.Fill(nwSet, "Instytyts");

                //Modify existing row
                var customersTable = nwSet.Tables["Instytyts"];

                //update rows in table
                var updRow = customersTable.Select("Instytyts_name='ІКНІ'")[0];
                updRow["Instytyts_name"] = "Інститут компютерних наук";
                updRow["Director"] = "Матвійків";

                var updRow2 = customersTable.Select("Instytyts_name='ІКТА'")[0];
                updRow2["Instytyts_name"] = "Інститут КТА ";
                updRow2["Director"] = "Головатий";

                //adding new rows to table
                customersTable.Rows.Add(6, "ІНПП", "Стахів");
                customersTable.Rows.Add(7, "ІТРЕ", "Дніпров");
                customersTable.Rows.Add(8, "ІЕСК", "Атом");

                //delete rows from table
                var delRow = customersTable.Select("Instytyts_id=8")[0];
                delRow.Delete();
                var delRow2 = customersTable.Select("Instytyts_id=7")[0];
                delRow2.Delete();

                //push all changes
                da.Update(nwSet, "Instytyts");
            }
        }

        //Kafedra
        static void ReadKafedraDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Kafedra ";
                connection.Open();
                DbDataReader rdr = cmd.ExecuteReader();
                string titlestr = String.Format("| {0,-20} | {1,-25} | {2,-40} |", "Назва кафедри", "Зав. кафедри", "К-сть докторів наук");
                Console.WriteLine(titlestr);

                while (rdr.Read())
                {
                    string str = String.Format("| {0,-20} | {1,-25} | {2,-40} |", rdr["Kafedra_name"].ToString(), rdr["Kafedra_zav"].ToString(), rdr["Count_Doctor_Science"].ToString());
                    Console.WriteLine(str);
                }
                connection.Close();
            }

        }

        static void UpAddDelKafedraDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Kafedra";
                var da = new SqlDataAdapter(cmd);
                var nwSet = new DataSet("Rusnak_laba2");
                var bldr = new SqlCommandBuilder(da);
                da.Fill(nwSet, "Kafedra");
                //Modify existing row
                var customersTable = nwSet.Tables["Kafedra"];

                var updRow = customersTable.Select("Kafedra_name='САПР'")[0];
                updRow["Kafedra_name"] = "СА проектування";
                updRow["Kafedra_zav"] = "Теслюк";
                updRow["Count_Doctor_Science"] = 13;
                updRow["Inst_Kaf_FK"] = 1;

                var updRow2 = customersTable.Select("Kafedra_name='ІСМ'")[0];
                updRow2["Kafedra_name"] = "Інформаційні системи";
                updRow2["Kafedra_zav"] = "Коротін";
                updRow2["Count_Doctor_Science"] = 8;
                updRow2["Inst_Kaf_FK"] = 1;

                var updRow3 = customersTable.Select("Kafedra_name='АСУ'")[0];
                updRow3["Kafedra_name"] = "Автоматизовані CA";
                updRow3["Kafedra_zav"] = "Світлик";
                updRow3["Count_Doctor_Science"] = 3;
                updRow3["Inst_Kaf_FK"] = 1;

                customersTable.Rows.Add(9, "АП", "Творчий", 2, 1);
                customersTable.Rows.Add(10, "ТАУ", "Зоряний", 5, 2);
                customersTable.Rows.Add(11, "ВТХ", "Квітковий", 7, 3);

                var delRow = customersTable.Select("Kafedra_id=11")[0];
                delRow.Delete();
                var delRow2 = customersTable.Select("Kafedra_id=10")[0];
                delRow2.Delete();

                da.Update(nwSet, "Kafedra");

            }
        }

        //Teachers 
        static void ReadTeachersDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Teachers";
                connection.Open();
                DbDataReader rdr = cmd.ExecuteReader();

                string titlestr = String.Format("| {0,-10} | {1,-5} | {2,-15} | {3,-25} |", "Імя", "Вік", "Номер тел.", "Науковий ступінь");
                Console.WriteLine(titlestr);
                
                while (rdr.Read())
                {
                    string str = String.Format("| {0,-10} | {1,-5} | {2,-15} | {3,-25} |", rdr["Teachers_name"].ToString(), rdr["Teachers_age"].ToString()
                                                                                         , rdr["Teachers_phone"].ToString(), rdr["Teachers_level"].ToString());
                    Console.WriteLine(str);
                }
                connection.Close();
            }

        }


        static void UpAddDelTeachersDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Teachers";
                var da = new SqlDataAdapter(cmd);
                var nwSet = new DataSet("Rusnak_laba2");
                var bldr = new SqlCommandBuilder(da);
                da.Fill(nwSet, "Teachers");
                //Modify existing row
                var customersTable = nwSet.Tables["Teachers"];

                var updRow = customersTable.Select("Teachers_name='Лобур'")[0];
                updRow["Teachers_name"] = "ЛОБУР М В";
                updRow["Teachers_age"] = 50;
                updRow["Teachers_phone"] = "0987553689";
                updRow["Teachers_level"] = "Доктор тех. наук";
                updRow["Kaf_Teach_FK"] = 1;

                customersTable.Rows.Add(10, "Бокла", 35, "097652353", "Асистент", 1);
                customersTable.Rows.Add(11, "Климкович", 40, "093652353", "Асистент", 2);
                customersTable.Rows.Add(12, "Мазур", 55, "063652353", "Доцент", 5);

                var delRow = customersTable.Select("Teachers_id= 12")[0];
                delRow.Delete();

                var delRow1 = customersTable.Select("Teachers_id=11")[0];
                delRow1.Delete();

                da.Update(nwSet, "Teachers");

            }
        }

        //Subjects
        static void ReadSubjectsDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Subjects";
                connection.Open();
                DbDataReader rdr = cmd.ExecuteReader();

                string titlestr = String.Format("| {0,-30} | {1,-20} | {2,-25} |", "Предмет", "К-сть годин", "Тип захисту");
                Console.WriteLine(titlestr);
                
                while (rdr.Read())
                {
                    string str = String.Format("| {0,-30} | {1,-20} | {2,-25} |" , rdr["Subject_name"].ToString(), rdr["Subject_hour"].ToString(), rdr["Subject_Type_Ex"].ToString());
                    Console.WriteLine(str);
                }
                connection.Close();
            }
        }

        static void UpAddDeiSubjectsDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Subjects";
                var da = new SqlDataAdapter(cmd);
                var nwSet = new DataSet("Rusnak_laba2");
                var bldr = new SqlCommandBuilder(da);
                da.Fill(nwSet, "Subjects");
                //Modify existing row
                var customersTable = nwSet.Tables["Subjects"];

                var updRow = customersTable.Select("Subject_id=1")[0];
                updRow["Subject_name"] = "Архітектура систем";
                updRow["Subject_hour"] = 120;
                updRow["Subject_Type_Ex"] = "екзамен";
                // updRow["Subject_FK"] = 2;



                var updRow2 = customersTable.Select("Subject_id=2")[0];
                updRow2["Subject_name"] = "ТО САПР";
                updRow2["Subject_hour"] = 120;
                updRow2["Subject_Type_Ex"] = "залік";
                //  updRow2["Subject_FK"] = 2;



                customersTable.Rows.Add(8, "Програмування C#", 150, "екзамен");
                customersTable.Rows.Add(9, "Програмування Java", 150, "екзамен");
                customersTable.Rows.Add(10, "Програмування C++", 150, "екзамен");

                var delRow = customersTable.Select("Subject_id=10")[0];
                delRow.Delete();

                var delRow1 = customersTable.Select("Subject_id=9")[0];
                delRow1.Delete();

                da.Update(nwSet, "Subjects");
            }
        }

        //Teachers_Subject
        static void ReadTeachers_SubjectDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Teachers_Subject";
                connection.Open();
                DbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["Teacher_Subject_id"]);
                }
                connection.Close();
            }
        }

        static void UpAddDeTeachers_SubjectDbCommand(string url)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Teachers_Subject";
                var da = new SqlDataAdapter(cmd);
                var nwSet = new DataSet("Rusnak_laba2");
                var bldr = new SqlCommandBuilder(da);
                da.Fill(nwSet, "Teachers_Subject");
                //Modify existing row
                var customersTable = nwSet.Tables["Teachers_Subject"];

                var updRow = customersTable.Select("Teacher_Subject_id=1")[0];
                updRow["Teachers_FK"] = 1;
                updRow["Subject_FK"] = 2;

                var updRow1 = customersTable.Select("Teacher_Subject_id=2")[0];
                updRow1["Teachers_FK"] = 2;
                updRow1["Subject_FK"] = 2;


                customersTable.Rows.Add(6, 1, 2);
                customersTable.Rows.Add(7, 1, 2);
                customersTable.Rows.Add(8, 1, 3);
                customersTable.Rows.Add(9, 2, 3);


                da.Update(nwSet, "Teachers_Subject");
            }

        }

    }
}







