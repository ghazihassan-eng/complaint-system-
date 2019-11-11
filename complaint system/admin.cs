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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            adminpanel11.Hide();
            adminpanel21.Hide();
            adminpanel31.Hide();
            adminpanel41.Hide();
            adminpanel51.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGreen;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            adminpanel11.Show();
            adminpanel11.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGreen;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            adminpanel21.Show();
            adminpanel21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkGreen;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            adminpanel31.Show();
            adminpanel31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkGreen;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            adminpanel41.Show();
            adminpanel41.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkGreen;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
            button3.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            adminpanel51.Show();
            adminpanel51.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkGreen;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button3.BackColor = Color.White;
            button7.BackColor = Color.White;

            this.Hide();
        }

        private void adminpanel31_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.DarkGreen;

            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
