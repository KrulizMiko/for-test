
using System.Data;
using System.Data.SQLite;

namespace Сельскохозяйственные_работы
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SQLiteConnection DB = new SQLiteConnection("DataSource=dbdb.db");

        string q1 = "SELECT Enterprise_Products.Revenue - Suppliers.Cost_suppier as Renta, Enterprise_Products.id_company from Enterprise_Products, Suppliers where strftime('%Y', Date_sales) = strftime('%Y', 'now') and Renta < 0 or Renta = 0 GROUP BY Enterprise_Products.id_company";
        string q2 = "SELECT Company.Type_ownership, Company.Name, max(Enterprise_Products.Revenue) as [Наибольший доход] FROM Enterprise_Products INNER JOIN Company ON Enterprise_Products.id_company = Company.id_company INNER JOIN Products ON Enterprise_Products.id_product = Products.id_product WHERE Enterprise_Products.id_product = 5;";
        string q3 = "SELECT Company.Name, Suppliers.Volume * Products.Purchase_price / Company.Number_employees as ress, Company.Number_employees FROM Company, Suppliers, Products WHERE Company.Name = 'Камаз' GROUP by Company.id_company;";
        string q4 = "SELECT Products.Product_name, Enterprise_Products.Revenue, Suppliers.Cost_suppier FROM Enterprise_Products INNER JOIN Products ON Enterprise_Products.id_product = Products.id_product INNER JOIN Suppliers on Enterprise_Products.id_suppliers = Suppliers.id_suppliers WHERE Cost_suppier > Revenue;";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataGridViewOnDBBrowser();
        }

        private void LoadDataGridViewOnDBBrowser()
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        #region Запросы
        private void Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q1, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void Query2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q2, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void Query3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q3, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void Query4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter(q4, DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }
        #endregion

        #region Таблицы
        private void ProductsQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Products", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }



        private void SalesQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Enterprise_Products", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void EmployeesQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Employees", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void SuppliesQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Suppliers", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }

        private void CompanyQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("select * from Company", DB);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка подключение к базе данных:\n" + ex);
            }
        }
        #endregion     
    }
}
