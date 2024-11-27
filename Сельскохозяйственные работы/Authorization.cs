using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сельскохозяйственные_работы
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public void Next()
        {
            Application.Run(new MainForm());
        }

        private void SalesQ_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string psw = Password.Text;
            try
            {
                if (name.Trim() == "")
                {
                    MessageBox.Show("Введите свое имя!");
                }
                else if (psw.Trim() == "")
                {
                    MessageBox.Show("Введите свой пароль!");
                }
                else
                {
                    string query = "select count(*) from Employees where Name = @name and Password = @psw";
                    SQLiteConnection DB = new SQLiteConnection("DataSource=dbdb.db");
                    SQLiteCommand cmd = new SQLiteCommand(query, DB);
                    DB.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@psw", psw);
                    cmd.ExecuteNonQuery();  

                    long count = (long)cmd.ExecuteScalar(); 
                    if (count > 0) //проверка из бд
                    {
                        this.Close();
                        Thread thread = new Thread(Next);
                        thread.Start();
                        MessageBox.Show("Приветсвуем!");
                    }
                    else
                    {
                        MessageBox.Show("Ваши данные не верны!");
                    }
                    DB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка авторизации:\n" + ex);
            }
        }
    }
}
