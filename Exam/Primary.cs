using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exam
{
    public partial class Primary : Form
    {
        public Primary()
        {
            InitializeComponent();
        }
        public static Show Show = new Show();
        private void Primary_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=salon; Integrated Security=SSPI;");
            con.Open();
            string sql = "select Last_name as Имя, Middle_name as Фамилия, First_name as Отчество from Employee";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            rad.Close();
            con.Close();


          
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show.Show();
        }
        public static Zakaz Zakaz = new Zakaz();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zakaz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
