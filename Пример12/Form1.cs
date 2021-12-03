using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using System.Data.SQLite;
using Finisar.SQLite;



namespace sqlite
{
    public partial class mainForm : Form
    {
        #region глобальные переменные
        // инициализируем глобальные переменные используемые во всей программе
        //private sqliteclass mydb = null;  // подключаем класс sqliteclass в котором производим все манипуляции с БД
        sqliteclass mydb = new sqliteclass();
        private string sCurDir = string.Empty;
        private string sPath = string.Empty;
        private string sSql = string.Empty;
        public bool cheking = false;
        private string manualCmd = string.Empty;
        
        #endregion

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sPath = Path.Combine(Application.StartupPath, "sql.sqlite");
            /*mainTextBox.Text = */ mainTextBox.AppendText("БД успешно создана и располагается в:"+ Environment.NewLine + sPath);// Text = sPath; 
        }
        #region кнопки
        private void createButton_Click(object sender, EventArgs e)
        {

               // запрос создающий таблицу с определёнными полями

               //sSql = @"CREATE TABLE if not exists [birthday]([id] INTEGER PRIMARY KEY AUTOINCREMENT,[FIO] TEXT NOT NULL,[bdate] datetime NOT NULL,[gretinyear] INTEGER DEFAULT 0);";
               sSql = @"CREATE TABLE if not exists [accel]([id] INTEGER PRIMARY KEY AUTOINCREMENT,[name] TEXT NOT NULL,[expdate] datetime NOT NULL, [energy] INTEGER DEFAULT 0, [ratio] FLOAT DEFAULT 0, [comment] TEXT);";

               mydb.execNonQuery(sPath, sSql, 0);
           
            MessageBox.Show("Таблица создана!");
            return;

        }
        private void addButton_Click(object sender, EventArgs e)
        {

                //sSql = @"INSERT INTO birthday (FIO,bdate,gretinyear) VALUES('Александр Сергеевич Пушкин','1799-06-06',0);";
                sSql = @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Большой коллайдер','2014-08-28', 11200, 0.43, 'Cтрана Швейцария, первый запуск');";    

                //Проверка работы
                if (mydb.execNonQuery(sPath, sSql, 1) == 0)
                {
                    MessageBox.Show("Ошибка записи!");
                }
                else
                {
                    MessageBox.Show("Записи успешно добавлены!");
                }

                return;
        }

        private void readButton_Click(object sender, EventArgs e)
        {

                sSql = "SELECT * FROM  accel;";
                //string buf = @"F:\sqlite\bin\Debug\mybd.sqlite";

                DataRow[] datarows = mydb.dataRowExec(sPath, sSql);
                if (datarows == null)
                {
                    MessageBox.Show("Ошибка чтения!");
                    mydb = null;
                    return;
                }
 
                mainTextBox.Text += Environment.NewLine; 
  
                foreach (DataRow dr in datarows)
                {
                   //mainTextBox.Text += dr["id"].ToString().Trim() + "  " + dr["FIO"].ToString().Trim() + "  " + dr["bdate"].ToString().Trim() + Environment.NewLine;
                   //mainTextBox.AppendText( dr["id"].ToString().Trim() + "  " + dr["FIO"].ToString().Trim() + "  " + dr["bdate"].ToString().Trim() + Environment.NewLine );
                    mainTextBox.AppendText(dr["id"].ToString().Trim() + "  " + dr["name"].ToString().Trim() + "  " + dr["expdate"].ToString().Trim() + "  "
                                         + dr["energy"].ToString().Trim() + "  " + dr["ratio"].ToString().Trim() + "  "
                                         + dr["comment"].ToString().Trim() + Environment.NewLine);

                }

                
        }

        private void ereaseButton_Click(object sender, EventArgs e)
        {

                sSql = "DELETE FROM accel";
                if (mydb.execNonQuery(sPath, sSql, 1) == 0)
                {
                    //mainTextBox.Text = "Ошибка удаления записи!";
                    MessageBox.Show("Ошибка удаления записи!");
                    mydb = null;
                    return;
                }
                
                mainTextBox.Text = "Записи удалены из БД!";
                return;

        }
        
        private void editButton_Click(object sender, EventArgs e)
        {

                sSql = @"UPDATE accel SET energy=15700 WHERE name LIKE('%коллайдер%');";
                //Проверка работы
                if (mydb.execNonQuery(sPath, sSql, 1) == 0)
                {
                    //mainTextBox.Text = "Ошибка обновления записи!";
                    MessageBox.Show("Ошибка редактирования записи!");
                    mydb = null;
                    return;
                }
                else
                {
                    //mainTextBox.Text = "Запись исправлена!";
                    MessageBox.Show("Запись успешно отредактирована!");
                }

        }
        #endregion


        // Обработчик - [ОК для SQL-Запроса]
        private void okButton_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = null;
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();

            sSql = cmdTextBox.Text;

            mainTextBox.Text = mainTextBox.Text + "\r\n" + sSql;     // AppendText(sSql + "\r\n");
          
            try
            {
                using (SQLiteConnection con = new SQLiteConnection())
                {
                    con.ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
                    con.Open();
                    using (SQLiteCommand sqlCommand = con.CreateCommand())
                    {
                        dataadapter = new SQLiteDataAdapter(sSql, con);
                        dataset.Reset();
                        dataadapter.Fill(dataset);

                        if (dataset.Tables.Count > 0)
                        {
                            dataGridView1.DataSource = dataset.Tables[0].DefaultView;
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                        }


                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                
        }


        // Обработчик - [Вывод таблицы в DataGrid]
        private void button1_Click(object sender, EventArgs e)
        {
            //DataRow[] datarows = null;
            SQLiteDataAdapter dataadapter = null;
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();

            sSql = "SELECT * FROM  accel;";
            
            try
            {
                using (SQLiteConnection con = new SQLiteConnection())
                {
                    con.ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
                    con.Open();
                    using (SQLiteCommand sqlCommand = con.CreateCommand())
                    {
                        dataadapter = new SQLiteDataAdapter(sSql, con);
                        dataset.Reset();
                        dataadapter.Fill(dataset);
                        //datatable = dataset.Tables[0];
                        //datarows = datatable.Select();
                        
                        dataGridView1.DataSource = dataset.Tables[0].DefaultView;


                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                //datarows = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] accels = 
            {
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Большой коллайдер','2014-08-28', 11200, 0.53, 'Cтрана Швейцария, первый запуск');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Синхрофазотрон','1983-11-15', 8950, 0.78, 'Дубна');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Линейный ускоритель','1992-06-07', 19080, 0.14, 'Стэнфорд (США)');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Теватрон','2002-07-21', 7600, 0.68, 'Фермилаб (США)');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Циклотрон','2013-04-19', 10100, 0.47, 'Калифорния (США)');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('SPS','2009-12-07', 9345, 0.55, 'ЦЕРН');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Антипротонный ускоритель','2014-09-18', 10900, 0.65, 'ЦЕРН');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('Микротрон','1987-03-17', 6300, 0.81, 'Германия');",
                @"INSERT INTO accel (name, expdate, energy, ratio, comment) VALUES('ALBA','2000-04-11', 7800, 0.44, 'Каталония (Испания)');"
              
            };

            foreach (string str in accels)
            {
                sSql = str;

                //Проверка работы
                if (mydb.execNonQuery(sPath, sSql, 1) == 0)
                {
                    MessageBox.Show("Ошибка записи!");
                    return;
                }
                
            }

            MessageBox.Show("Записи успешно добавлены!");
            return;
        }

        // обработчик dbl-click дляя очистки строки с SQL-запросом
        private void cmdTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmdTextBox.Clear();
        }


        // Обработчик "маленького" ОК для большого текстобкса - выполнить выделенный SQL-запрос 
        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = null;
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();

            sSql = mainTextBox.SelectedText;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection())
                {
                    con.ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
                    con.Open();
                    using (SQLiteCommand sqlCommand = con.CreateCommand())
                    {
                        dataadapter = new SQLiteDataAdapter(sSql, con);
                        dataset.Reset();
                        dataadapter.Fill(dataset);

                        if (dataset.Tables.Count > 0)
                        {
                            dataGridView1.DataSource = dataset.Tables[0].DefaultView;
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                        }


                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


        // Обработчик для мега-заполнения БД пучков
        private void button4_Click(object sender, EventArgs e)
        {
            try{
            Random rnd = new Random(103455);
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            con.Open();
            SQLiteCommand sqlCommand = con.CreateCommand();
            int Ncnt = 0;

            string[] accels = 
            {
                //@"DROP TABLE prt",
                //@"DROP TABLE pnt",

                @"CREATE TABLE if not exists [prt]([id] INTEGER PRIMARY KEY AUTOINCREMENT,[exp_id] integer, FOREIGN KEY (exp_id) REFERENCES exp);",
                //@"CREATE TABLE if not exists [pnt]([id] INTEGER PRIMARY KEY AUTOINCREMENT,[prt_id] integer, [ksi] FLOAT, [gamma] FLOAT, FOREIGN KEY (prt_id) REFERENCES prt(id)UNIQUE (prt_id, ksi)  );"
                @"CREATE TABLE if not exists [pnt]([id] INTEGER PRIMARY KEY AUTOINCREMENT,[prt_id] integer, [ksi] FLOAT, [gamma] FLOAT, FOREIGN KEY (prt_id) REFERENCES prt(id) );"       // пока без , UNIQUE (prt_id, ksi) 
                

              
            };


           foreach (string str in accels)
           {
               sqlCommand.CommandText = str;
               sqlCommand.ExecuteNonQuery();
            }
           
           int exp_id;
if( false )
{          // в таблицу PRT кидаем 100 ч. для exp 1 2 3 4 5 6 
           
           /*for (exp_id = 1; exp_id <= 6; exp_id++)
           {
               int N_prt = 41 + rnd.Next(15);
               for (int prt = 1; prt < N_prt; prt++)
               {
                   string str = "INSERT INTO prt values(NULL," + exp_id.ToString() + ")";
                   sqlCommand.CommandText = str;
                   sqlCommand.ExecuteNonQuery();
               }
           }*/
           // тоже но случайному эксперименту
           for (int i = 0; i < 50 * 6 + 11; i++)
           {
               string str = "INSERT INTO prt values(NULL," + (rnd.Next(6)+1).ToString() + ")";
               sqlCommand.CommandText = str;
               sqlCommand.ExecuteNonQuery();
           }
}

if (/*true*/false)
{   // цикл по экспериментам
    for (exp_id = 0; exp_id < 7; exp_id++)
    {
        mainTextBox.AppendText(exp_id + "\r\n");
        // получение id-частиц в эксперименте
        sSql = "SELECT * FROM prt where exp_id=" + exp_id;
        DataRow[] datarows = mydb.dataRowExec(sPath, sSql);
        // создаём сетку ksi (для этого экспа)
        int N_pnt = 60 + rnd.Next(25);
        double[] ksiarr = new double[N_pnt];
        for (int ksi = 0; ksi < ksiarr.Length; ksi++)
        { ksiarr[ksi] = ksi * (0.01 + 0.001*exp_id ); }
        // цикл по номерам частиц
        foreach (DataRow dr in datarows)
        {
            // каждой частице-треку добавляем точек
            int prt_id = int.Parse(dr["id"].ToString().Trim());
            double a = 11.0 * rnd.NextDouble();
            double gamma0 = 1 + 0.5 * rnd.NextDouble();
            // цикл по точкам-pnt трека
            for (int pnt = 0; pnt < N_pnt; pnt++)
            {
                double gamma = a * ksiarr[pnt] + gamma0 + 0.3 * rnd.NextDouble();
                //string gammas = ksiarr[pnt].ToString().Replace(',', '.');
                string str = "INSERT INTO pnt values(NULL," + prt_id.ToString() + ", " + ksiarr[pnt].ToString().Replace(',', '.') + ", " + gamma.ToString().Replace(',', '.') + ")";
                sqlCommand.CommandText = str;
                sqlCommand.ExecuteNonQuery();
            } // по точкам
        } // по номерам частиц
    } // по экспериментам

}

if (true/*false*/)
{          // перемешивание в таблице pnt методом Swap
    for (int i = 1; i < 12000; i++)
    {
        int rowid = rnd.Next(22000) + 1;
        if (i % 100 == 0) { mainTextBox.AppendText(i + "\r\n"); }
        sSql = "SELECT * FROM pnt where id = " + i;
        DataRow[] datarows1 = mydb.dataRowExec(sPath, sSql);
        sSql = "SELECT * FROM pnt where id = " + rowid;
        DataRow[] datarows2 = mydb.dataRowExec(sPath, sSql);

        if ((datarows1.Length > 0) && (datarows2.Length > 0))
        {
            DataRow drr1 = datarows1[0];
            DataRow drr2 = datarows2[0];
            //sSql = "DELETE FROM pnt where id=" + rowid;
            sSql = string.Format("UPDATE pnt SET ksi={0} where id={1}", 55, rowid);
            sqlCommand.CommandText = sSql;
            sqlCommand.ExecuteNonQuery();
            sSql = string.Format("UPDATE pnt SET prt_id={0}, ksi={1}, gamma={2} where id={3}", drr2["prt_id"], drr2["ksi"].ToString().Replace(',', '.'), drr2["gamma"].ToString().Replace(',', '.'), i);
            sqlCommand.CommandText = sSql;
            sqlCommand.ExecuteNonQuery();
            sSql = string.Format("UPDATE pnt SET prt_id={0}, ksi={1}, gamma={2} where id={3}", drr1["prt_id"], drr1["ksi"].ToString().Replace(',', '.'), drr1["gamma"].ToString().Replace(',', '.'), rowid);
            //sSql = "INSERT INTO pnt VALUES(NULL, " + drr2["prt_id"] + ", " + drr2["ksi"].ToString().Replace(',', '.') + ", " + drr2["gamma"].ToString().Replace(',', '.') + ")";
            sqlCommand.CommandText = sSql;
            sqlCommand.ExecuteNonQuery();
        }
    }
}                           
                
           
            con.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mainTextBox_KeyDown(object sender, KeyEventArgs e)     
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                if (sender == cmdTextBox) { okButton_Click(sender, e); }
                if (sender == mainTextBox) { button3_Click(sender, e); }
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.Q) { cmdTextBox.Clear(); }
            if (e.Control && e.KeyCode == Keys.R) { cmdTextBox.Text += mainTextBox.SelectedText; }

        }



    }
}
