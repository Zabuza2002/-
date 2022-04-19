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
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }
        public static Primary Primary = new Primary();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Primary.Show();
        }

        private void Show_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=salon; Integrated Security=SSPI;");
            con.Open();
            string sql = "select * from service";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            rad.Close();
            con.Close();
        }
    }
}
