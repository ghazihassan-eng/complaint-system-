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
namespace complaint_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
       // SqlConnection con;
        DataTable dt;
        connection con = new connection();
        public void load()
        {
           // con = new SqlConnection("Data Source=DESKTOP-K4OP1A5;Initial Catalog=complaint_system;Integrated Security=True");
            //con.Open();
            con.connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //if (textBox1.Text == "pakistan" && textBox2.Text == "12345")
            //{
                
            //    admin ad = new admin();
            //    ad.ShowDialog();
            //    this.Hide();

            //}
            //else
            //{
            //    MessageBox.Show("PLEASE PROVIDE CORRECT ID/PASSWORD");
            //}
            load();
            SqlDataAdapter adp = new SqlDataAdapter("select * from ADMIN_LOGIN where NAME ='" + textBox1.Text + "' and PASSWORD ='" + textBox2.Text + "'", con.connect());
            dt = new DataTable();
            adp.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                if(dt.Rows[0]["NAME"].ToString() == "admin")
                {
                    admin ad = new admin();
                    ad.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD");
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
