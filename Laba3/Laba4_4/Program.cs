using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {   Console.OutputEncoding = Encoding.GetEncoding(1251);

            // Create table Instytyts
            DataTable datatable_Instytyts = new DataTable("Instytyts");

            DataColumn Instytyts_id = new DataColumn("Instytyts_id", typeof(System.Int32));
            // set features of Primery Key
            Instytyts_id.AutoIncrement = true;
            Instytyts_id.Unique = true;
            Instytyts_id.AutoIncrementSeed = 1;
            Instytyts_id.AutoIncrementStep = 1;

            DataColumn Instytyts_name = new DataColumn("Instytyts_name", typeof(string));
            DataColumn Director = new DataColumn("Director", typeof(string));

            //creation of полів
            datatable_Instytyts.Columns.Add(Instytyts_id);
            datatable_Instytyts.Columns.Add(Instytyts_name);
            datatable_Instytyts.Columns.Add(Director);

            // set Primery Key
            datatable_Instytyts.PrimaryKey = new DataColumn[] { Instytyts_id };


            //Create table Kafedra
            DataTable datatable_Kafedra = new DataTable("Kafedra");
            DataColumn Kafedra_id = new DataColumn("Kafedra_id", typeof(int));

            Kafedra_id.AutoIncrement = true;
            Kafedra_id.Unique = true;
            Kafedra_id.AutoIncrementSeed = 1;
            Kafedra_id.AutoIncrementStep = 1;

            DataColumn Kafedra_name = new DataColumn("Kafedra_name", typeof(string));
            DataColumn Kafedra_zav = new DataColumn("Kafedra_zav", typeof(string));
            DataColumn Cout_Doctor_sciense = new DataColumn("Cout_Doctor_sciense", typeof(Int32));

            DataColumn Inst_Kaf_FK = new DataColumn("Inst_Kaf_FK", typeof(int));


            datatable_Kafedra.Columns.Add(Kafedra_id);
            datatable_Kafedra.Columns.Add(Kafedra_name);
            datatable_Kafedra.Columns.Add(Kafedra_zav);
            datatable_Kafedra.Columns.Add(Cout_Doctor_sciense);

            datatable_Kafedra.Columns.Add(Inst_Kaf_FK);

            datatable_Kafedra.PrimaryKey = new DataColumn[] { Kafedra_id };


            //Create table Teachers
            DataTable datatable_Teachers = new DataTable("Teachers");

            DataColumn Teachers_id = new DataColumn("Teachers_id", typeof(int));

            Teachers_id.AutoIncrement = true;
            Teachers_id.Unique = true;
            Teachers_id.AutoIncrementSeed = 1;
            Teachers_id.AutoIncrementStep = 1;

            DataColumn Teachers_name = new DataColumn("Teachers_name", typeof(string));
            DataColumn Teachers_age = new DataColumn("Teachers_age", typeof(Int32));
            DataColumn Teachers_level = new DataColumn("Teachers_level", typeof(string));
            DataColumn Teachers_phone = new DataColumn("Teachers_phone", typeof(string));


            DataColumn Kaf_Teach_FK = new DataColumn("Kaf_Teach_FK", typeof(int));


            datatable_Teachers.Columns.Add(Teachers_id);
            datatable_Teachers.Columns.Add(Teachers_name);
            datatable_Teachers.Columns.Add(Teachers_age);
            datatable_Teachers.Columns.Add(Teachers_level);
            datatable_Teachers.Columns.Add(Teachers_phone);
            datatable_Teachers.Columns.Add(Kaf_Teach_FK);


            datatable_Teachers.PrimaryKey = new DataColumn[] { Teachers_id };


            //Create table Subjects
            DataTable datatable_Subjects = new DataTable("Subjects");

            DataColumn Subjects_id = new DataColumn("Subjects_id", typeof(int));

            Subjects_id.AutoIncrement = true;
            Subjects_id.Unique = true;
            Subjects_id.AutoIncrementSeed = 1;
            Subjects_id.AutoIncrementStep = 1;

            DataColumn Subjects_name = new DataColumn("Subjects_name", typeof(string));
            DataColumn Subjects_hour = new DataColumn("Subjects_hour", typeof(Int32));
            DataColumn Subjects_TypeEx = new DataColumn("Subjects_TypeEx", typeof(string));


            datatable_Subjects.Columns.Add(Subjects_id);
            datatable_Subjects.Columns.Add(Subjects_name);
            datatable_Subjects.Columns.Add(Subjects_hour);
            datatable_Subjects.Columns.Add(Subjects_TypeEx);

          
            datatable_Subjects.PrimaryKey = new DataColumn[] { Subjects_id };



            //Create table Teachers-Subject N-N

            DataTable datatable_Teachers_Subject = new DataTable("Teachers_Subject");

            DataColumn Teachers_Subject_id = new DataColumn("Teachers_Subject_id", typeof(int));

            Teachers_Subject_id.AutoIncrement = true;
            Teachers_Subject_id.Unique = true;
            Teachers_Subject_id.AutoIncrementSeed = 1;
            Teachers_Subject_id.AutoIncrementStep = 1;

            DataColumn Teachers_FK = new DataColumn("Teachers_FK", typeof(int));
            DataColumn Subject_FK = new DataColumn("Subject_FK", typeof(int));

            datatable_Teachers_Subject.Columns.Add(Teachers_Subject_id);
            datatable_Teachers_Subject.Columns.Add(Teachers_FK);
            datatable_Teachers_Subject.Columns.Add(Subject_FK);
            datatable_Teachers_Subject.PrimaryKey = new DataColumn[] { Teachers_Subject_id };


            DataSet dataset = new DataSet("Lab_4_Rusnak_beta");

            dataset.Tables.Add(datatable_Instytyts);
            dataset.Tables.Add(datatable_Kafedra);
            dataset.Tables.Add(datatable_Teachers);
            dataset.Tables.Add(datatable_Subjects);
            dataset.Tables.Add(datatable_Teachers_Subject);


            // Create Relations
            dataset.Relations.Add("Instytyts_Kafedra_rel", datatable_Instytyts.Columns["Instytyts_id"], datatable_Kafedra.Columns["Kafedra_id"]);
            dataset.Relations.Add("Kafedra_Teachers_rel", datatable_Kafedra.Columns["Kafedra_id"], datatable_Teachers.Columns["Kaf_Teach_FK"]);
            dataset.Relations.Add("Teachers_Subjects_rel_N_N", datatable_Teachers.Columns["Teachers_id"], datatable_Teachers_Subject.Columns["Teachers_FK"]);
           //dataset.Relations.Add("Subjects_Teachers_rel_N_N", datatable_Teachers.Columns["Subjects_id"], datatable_Teachers_Subject.Columns["Subjects_FK"]);


            //1_fill in tabel Instytyts
            DataRow newInst = datatable_Instytyts.NewRow();
            newInst["Instytyts_name"] = "ІКНІ";
            newInst["Director"] = "Медиковський";
                        
            DataRow newInst2 = datatable_Instytyts.NewRow();
            newInst2["Instytyts_name"] = "ІКТА";
            newInst2["Director"] = "Рильський";

            DataRow newInst3 = datatable_Instytyts.NewRow();
            newInst3["Instytyts_name"] = "ІНЕМ";
            newInst3["Director"] = "Дворян";

            DataRow newInst4 = datatable_Instytyts.NewRow();
            newInst4["Instytyts_name"] = "ІБІД";
            newInst4["Director"] = "Іванов";

            DataRow newInst5 = datatable_Instytyts.NewRow();
            newInst5["Instytyts_name"] = "ІАРХ";
            newInst5["Director"] = "Кінаш";

            datatable_Instytyts.Rows.Add(newInst);
            datatable_Instytyts.Rows.Add(newInst2);
            datatable_Instytyts.Rows.Add(newInst3);
            datatable_Instytyts.Rows.Add(newInst4);
            datatable_Instytyts.Rows.Add(newInst5);

            //2_fill in tabel Kafedra
            DataRow newKaf1 = datatable_Kafedra.NewRow();
            newKaf1["Kafedra_name"] = "САПР";
            newKaf1["Kafedra_zav"] = "Лобур";
            newKaf1["Cout_Doctor_sciense"] = 10;
            newKaf1["Inst_Kaf_FK"] = 1; 

            DataRow newKaf2 = datatable_Kafedra.NewRow();
            newKaf2["Kafedra_name"] = "ІСМ";
            newKaf2["Kafedra_zav"] = "Литвин";
            newKaf2["Cout_Doctor_sciense"] = 7;
            newKaf1["Inst_Kaf_FK"] = 2;

            DataRow newKaf3 = datatable_Kafedra.NewRow();
            newKaf3["Kafedra_name"] = "АСУ";
            newKaf3["Kafedra_zav"] = "Дворян";
            newKaf3["Cout_Doctor_sciense"] = 5;
            newKaf1["Inst_Kaf_FK"] = 3;


            DataRow newKaf4 = datatable_Kafedra.NewRow();
            newKaf4["Kafedra_name"] = "ПЗ";
            newKaf4["Kafedra_zav"] = "Мастер";
            newKaf4["Cout_Doctor_sciense"] = 3;
            newKaf1["Inst_Kaf_FK"] = 4;

            DataRow newKaf5 = datatable_Kafedra.NewRow();
            newKaf5["Kafedra_name"] = "СШІ";
            newKaf5["Kafedra_zav"] = "Рибалко";
            newKaf5["Cout_Doctor_sciense"] = 5;
            newKaf1["Inst_Kaf_FK"] = 5;

            datatable_Kafedra.Rows.Add(newKaf1);
            datatable_Kafedra.Rows.Add(newKaf2);
            datatable_Kafedra.Rows.Add(newKaf3);
            datatable_Kafedra.Rows.Add(newKaf4);
            datatable_Kafedra.Rows.Add(newKaf5);

            //3_fill in tabel Teachers
            DataRow newTeach1 = datatable_Teachers.NewRow();
            newTeach1["Teachers_name"] = "Лобур";
            newTeach1["Teachers_age"] = 45;
            newTeach1["Teachers_level"] = "Професор";
            newTeach1["Teachers_phone"] = "0936998221";
            newTeach1["Kaf_Teach_FK"] = 1;

            DataRow newTeach2 = datatable_Teachers.NewRow();
            newTeach2["Teachers_name"] = "Тимощук";
            newTeach2["Teachers_age"] = 55;
            newTeach2["Teachers_level"] = "Доцент";
            newTeach2["Teachers_phone"] = "0986998221";
            newTeach1["Kaf_Teach_FK"] = 2;

            DataRow newTeach3 = datatable_Teachers.NewRow();
            newTeach3["Teachers_name"] = "Теслюк";
            newTeach3["Teachers_age"] = 40;
            newTeach3["Teachers_level"] = "Професор";
            newTeach3["Teachers_phone"] = "+380986998225";
            newTeach1["Kaf_Teach_FK"] = 1;

            DataRow newTeach4 = datatable_Teachers.NewRow();
            newTeach4["Teachers_name"] = "Денисюк";
            newTeach4["Teachers_age"] = 30;
            newTeach4["Teachers_level"] = "Доцент";
            newTeach4["Teachers_phone"] = "+38096998205";
            newTeach1["Kaf_Teach_FK"] = 1;

            DataRow newTeach5 = datatable_Teachers.NewRow();
            newTeach5["Teachers_name"] = "Панчак";
            newTeach5["Teachers_age"] = 55;
            newTeach5["Teachers_level"] = "Професор";
            newTeach5["Teachers_phone"] = "+380950998225";
            newTeach1["Kaf_Teach_FK"] = 3;

            datatable_Teachers.Rows.Add(newTeach1);
            datatable_Teachers.Rows.Add(newTeach2);
            datatable_Teachers.Rows.Add(newTeach3);
            datatable_Teachers.Rows.Add(newTeach4);
            datatable_Teachers.Rows.Add(newTeach5);

            //4_fill in tabel Subjects
            DataRow newSubj1 = datatable_Subjects.NewRow();
            newSubj1["Subjects_name"] = "ТО САПР";
            newSubj1["Subjects_hour"] = 150;
            newSubj1["Subjects_TypeEx"] = "екзамен";

            DataRow newSubj2 = datatable_Subjects.NewRow();
            newSubj2["Subjects_name"] = "Моделювання систем";
            newSubj2["Subjects_hour"] = 90;
            newSubj2["Subjects_TypeEx"] = "залік";

            DataRow newSubj3 = datatable_Subjects.NewRow();
            newSubj3["Subjects_name"] = "English";
            newSubj3["Subjects_hour"] = 120;
            newSubj3["Subjects_TypeEx"] = "екзамен";

            DataRow newSubj4 = datatable_Subjects.NewRow();
            newSubj4["Subjects_name"] = "Системний аналіз";
            newSubj4["Subjects_hour"] = 150;
            newSubj4["Subjects_TypeEx"] = "екзамен";

            DataRow newSubj5 = datatable_Subjects.NewRow();
            newSubj5["Subjects_name"] = "Технології створення ПП";
            newSubj5["Subjects_hour"] = 120;
            newSubj5["Subjects_TypeEx"] = "екзамен";

            datatable_Subjects.Rows.Add(newSubj1);
            datatable_Subjects.Rows.Add(newSubj2);
            datatable_Subjects.Rows.Add(newSubj3);
            datatable_Subjects.Rows.Add(newSubj4);
            datatable_Subjects.Rows.Add(newSubj5);

            //5_fill in tabel Teachers_Subject
            DataRow newT_s1 = datatable_Teachers_Subject.NewRow();
            newT_s1["Teachers_FK"] = 1;
            newT_s1["Subject_FK"] = 1;

            DataRow newT_s2 = datatable_Teachers_Subject.NewRow();
            newT_s2["Teachers_FK"] = 2;
            newT_s2["Subject_FK"] = 2;

            DataRow newT_s3 = datatable_Teachers_Subject.NewRow();
            newT_s3["Teachers_FK"] = 3;
            newT_s3["Subject_FK"] = 3;

            DataRow newT_s4 = datatable_Teachers_Subject.NewRow();
            newT_s4["Teachers_FK"] = 4;
            newT_s4["Subject_FK"] = 4;

            DataRow newT_s5 = datatable_Teachers_Subject.NewRow();
            newT_s5["Teachers_FK"] = 5;
            newT_s5["Subject_FK"] = 5;

            datatable_Teachers_Subject.Rows.Add(newT_s1);
            datatable_Teachers_Subject.Rows.Add(newT_s2);
            datatable_Teachers_Subject.Rows.Add(newT_s3);
            datatable_Teachers_Subject.Rows.Add(newT_s4);
            datatable_Teachers_Subject.Rows.Add(newT_s5);

            //set state of row - Unchanged
            dataset.AcceptChanges();

            Console.WriteLine("База даних Інститут - Кафедра - Викладачі - Предмети");
            Console.WriteLine("Лабораторна робота №3");
            Console.WriteLine();

            //show existing database
            foreach (DataTable tables in dataset.Tables)
            {
                Console.WriteLine(tables.TableName);
                foreach (DataRow dr in tables.Rows)
                {
                    foreach (DataColumn dc in tables.Columns)
                    {
                        Console.Write(dr[dc].ToString() + " ");
                    }
                    Console.Write(dr.RowState.ToString());
                    Console.WriteLine();
                }
            }


            Console.WriteLine();
            Console.WriteLine("Для продовження натисніть Enter");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Сортування даних в таблицi Кафедра в алфавітному порядку:");
            DataView secondDW = new DataView(datatable_Kafedra);

            secondDW.Sort = "Kafedra_name, Cout_Doctor_sciense ASC";

            DataTable datatblStad = secondDW.ToTable();

            foreach (DataRowView row in secondDW)
            {
                Console.WriteLine(row["Kafedra_name"]);
                Console.WriteLine(row["Cout_Doctor_sciense"]);


            }

            Console.WriteLine();
            Console.WriteLine("Сортування даних в таблицi Викладачі за спаданням по віку:");
            DataView secondDW1 = new DataView(datatable_Teachers);
            secondDW1.Sort = "Teachers_age DESC";

            DataTable datatblStad1 = secondDW1.ToTable();

            foreach (DataRowView row in secondDW1)
            {
                string str = String.Format(" {0,-30}  {1,-18}", row["Teachers_name"].ToString(), row["Teachers_age"].ToString());
                Console.WriteLine(str);

            }


            Console.WriteLine();
            Console.WriteLine("Для продовження натисніть Enter");
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("Вносим змiни в таблицi");
            Console.WriteLine();
            
            //update
            {
                foreach (DataRow row in datatable_Teachers.Rows)
                {
                    if (row["Teachers_name"].ToString() == "Лобур")
                        row.SetField("Teachers_age", 50);

                    if (row["Teachers_name"].ToString() == "Теслюк")
                        row.SetField("Teachers_age", 45);

                    if (row["Teachers_name"].ToString() == "Панчак")
                        row.SetField("Teachers_age", 60);
                }

                datatable_Teachers.AcceptChanges();
              
               
                 foreach (DataRow subj in datatable_Subjects.Rows)
                   {
                   if (subj["Subjects_name"].ToString() == "ТО САПР")
                    subj.SetField("Subjects_name", "Теоритичні основи САПР");

                    if (subj["Subjects_name"].ToString() == "Моделювання систем")
                        subj.SetField("Subjects_name", "Моделювання динамічних систем");

                    if (subj["Subjects_name"].ToString() == "English")
                        subj.SetField("Subjects_name", "English for developers");
                }
                    datatable_Subjects.AcceptChanges();
                
                //show updated databases
                Console.WriteLine("Обновленi данi");
                DataView secdDW = new DataView(datatable_Teachers);
                secdDW.Sort = "Teachers_name ASC";

                DataTable dattblStad = secdDW.ToTable();
                string titlestr1 = String.Format("| {0,-30} | {1,-18}  ", "Викладач", "Вік викладача");
                Console.WriteLine(titlestr1);

                foreach (DataRowView row in secdDW)
                                {
                    string str = String.Format(" {0,-30}  {1,-18} ", row["Teachers_name"].ToString(), row["Teachers_age"].ToString());
                    Console.WriteLine(str);

                }
                Console.WriteLine();
                
                                 DataView subj_update = new DataView(datatable_Subjects);
                                 subj_update.Sort = "Subjects_name ASC";

                                  DataTable dattblStad_1 = subj_update.ToTable();

                string titlestr = String.Format("| {0,-30} | {1,-18} " , "Предмет", "К-сть годин");
                            Console.WriteLine(titlestr);

                foreach (DataRowView row in subj_update)
                   {
                    string str = String.Format(" {0,-30}  {1,-20} ", row["Subjects_name"].ToString(), row["Subjects_hour"].ToString());
                    Console.WriteLine(str);
                                }
                                Console.WriteLine();

                Console.WriteLine("Для продовження натисніть Enter");
                                Console.ReadKey();
                Console.WriteLine();

                //add
                //adding rows to Subjects
                DataRow newSubjc_add = datatable_Subjects.NewRow();
                newSubjc_add["Subjects_name"] = "Фізкультура";
                newSubjc_add["Subjects_hour"] = 90;
                newSubjc_add["Subjects_TypeEx"] = "зарах";

                datatable_Subjects.Rows.Add(newSubjc_add);
                datatable_Subjects.AcceptChanges();

                DataRow newSubjc_add1 = datatable_Subjects.NewRow();
                newSubjc_add1["Subjects_name"] = "Всесвітня історія";
                newSubjc_add1["Subjects_hour"] = 90;
                newSubjc_add1["Subjects_TypeEx"] = "залік";

                datatable_Subjects.Rows.Add(newSubjc_add1);
                datatable_Subjects.AcceptChanges();

                //adding rows to Instytyts
                DataRow newInst_add = datatable_Instytyts.NewRow();
                newInst_add["Instytyts_name"] = "ІГДГ";
                newInst_add["Director"] = "Король";
                datatable_Instytyts.Rows.Add(newInst_add);
                datatable_Instytyts.AcceptChanges();

                DataRow newInst_add1 = datatable_Instytyts.NewRow();
                newInst_add1["Instytyts_name"] = "ІНПП";
                newInst_add1["Director"] = "Король";
                datatable_Instytyts.Rows.Add(newInst_add1);
                datatable_Instytyts.AcceptChanges();


                //Result of adding rows
                Console.WriteLine("Доданi данi");
                Console.WriteLine();

                Console.WriteLine("Таблиця Предмети:");
                //show tabel Subjects
                DataView sedDW = new DataView(datatable_Subjects);
                 sedDW.Sort = "Subjects_name ASC";
                 DataTable dattlStad = sedDW.ToTable();
         
                foreach (DataRowView row  in sedDW)
                 {
                     Console.WriteLine(row["Subjects_name"]);
                  }
                Console.WriteLine();

                //show tabel Instytyts
                Console.WriteLine("Таблиця Інститути:");
                DataView sedDW1 = new DataView(datatable_Instytyts);
                sedDW1.Sort = "Instytyts_name ASC";
                DataTable dattlStad1 = sedDW1.ToTable();
                foreach (DataRowView row in sedDW1)
                {
                    Console.WriteLine(row["Instytyts_name"]);
                }
                 datatable_Instytyts.AcceptChanges();
                 datatable_Subjects.AcceptChanges();
            }

            Console.WriteLine();
            Console.WriteLine("Для продовження натисніть Enter");
            Console.ReadKey();
            Console.WriteLine();

            //datawiev
            {
                    DataSet ds = new DataSet();
                    ds = dataset.GetChanges();
                    Console.WriteLine("Внесенi змiни в таблицях");
                    foreach (DataTable tables in dataset.Tables)
                    {
                        Console.WriteLine(tables.TableName);
                        foreach (DataRow dr in tables.Rows)
                        {
                            foreach (DataColumn dc in tables.Columns)
                            {
                            Console.Write(dr[dc].ToString() + " ");
                            }
                                  Console.Write(dr.RowState.ToString());
                                  Console.WriteLine();
                        }
                    }
                }

                 Console.ReadKey();

            }

        }
    
}
