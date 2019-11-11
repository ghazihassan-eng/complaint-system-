using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace complaint_system
{
    public partial class adminpanel3 : UserControl
    {
        public adminpanel3()
        {
            InitializeComponent();
        }
       // SqlConnection con;
        connection con = new connection();
        public void load()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from KELECTRIC", con.connect());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void adminpanel3_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=DESKTOP-K4OP1A5;Initial Catalog=complaint_system;Integrated Security=True");
            //con.Open();
            con.connect();
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            var cell = ((DataGridView)sender)[col, row];

            DataGridViewRow rows = cell.OwningRow;

            textBox6.Text = rows.Cells["ID"].Value.ToString();
            textBox1.Text = rows.Cells["NAME"].Value.ToString();
            textBox2.Text = rows.Cells["CNIC"].Value.ToString();
            textBox3.Text = rows.Cells["AREA"].Value.ToString();
            textBox4.Text = rows.Cells["SUB_AREA"].Value.ToString();
            textBox5.Text = rows.Cells["COMPLAINT"].Value.ToString();
        }

       // SqlConnection co;
        public void display()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from SOLVED_KELECTRIC", con.connect());
            SqlCommand cm = new SqlCommand("insert into SOLVED_KELECTRIC(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con.connect());
            cm.ExecuteNonQuery();
            DataTable d = new DataTable();
            adp.Fill(d);
            dataGridView2.DataSource = d;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
               // co = new SqlConnection("Data Source=DESKTOP-K4OP1A5;Initial Catalog=complaint_system;Integrated Security=True");
                //co.Open();

                con.connect();
                display();
                SqlCommand cmd = new SqlCommand("delete from KELECTRIC where ID=" + textBox6.Text + "", con.connect());
                cmd.ExecuteNonQuery();
                load();
                textBox6.Clear();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from KELECTRIC where ID=" + textBox6.Text + "", con.connect());
                cmd.ExecuteNonQuery();
                load();
                textBox6.Clear();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
