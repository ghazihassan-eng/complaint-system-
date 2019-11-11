using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace complaint_system
{
    public partial class citizenform : Form
    {
        public citizenform()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkGreen;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            this.Hide();
        }

        private void citizenform_Load(object sender, EventArgs e)
        {
            citizenfront1.Show();
            citizenfront1.BringToFront();
            police1.Hide();
            suigas1.Hide();
            complaintdepartment31.Hide();
            complaintdepartment41.Hide();
            complaintde_partment51.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGreen;
            
            button6.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            police1.Show();
            police1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            police1.Hide();
            
            button2.BackColor = Color.DarkGreen;
            
            button1.BackColor = Color.White;
            button6.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            suigas1.Show();
            suigas1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            police1.Hide();

            button3.BackColor = Color.DarkGreen;
          
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button6.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            complaintdepartment31.Show();
            complaintdepartment31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            police1.Hide();

            button4.BackColor = Color.DarkGreen;
            
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button6.BackColor = Color.White;
            button5.BackColor = Color.White;
            complaintdepartment41.Show();
            complaintdepartment41.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            police1.Hide();

            button5.BackColor = Color.DarkGreen;
            
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button6.BackColor = Color.White;
            complaintde_partment51.Show();
            complaintde_partment51.BringToFront();
        }
    }
}
