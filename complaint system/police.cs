﻿using System;
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
    public partial class police : UserControl
    {
        public police()
        {
            InitializeComponent();
        }

        //SqlConnection con;
        connection con = new connection();
        private void police_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=DESKTOP-K4OP1A5;Initial Catalog=complaint_system;Integrated Security=True");
            //con.Open();
            con.connect();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.Enabled = true;

            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || maskedTextBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || radioButton11.Checked == false && radioButton12.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false && radioButton9.Checked == false && radioButton10.Checked == false && richTextBox1.Text == "")
            {
                MessageBox.Show("PLEASE ENTER VALID INFORMATION !!!");
            }
            else
            {

                try
                {
                    if (radioButton11.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton11.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton12.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton12.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton3.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton3.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton4.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton4.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton5.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton5.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton6.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton6.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton7.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton7.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton8.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton8.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton9.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton9.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else if (radioButton10.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + radioButton10.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();
                    }

                    else
                    {

                        SqlCommand cmd = new SqlCommand("insert into POLICE(NAME,CNIC,AREA,SUB_AREA,COMPLAINT)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + richTextBox1.Text + "')", con.connect());
                        cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("YOUR COMPLAINT IS SUCCESSFULLY SEND");
                    textBox1.Clear();
                    maskedTextBox1.Clear();

                    comboBox2.Text = "";
                    comboBox2.Enabled = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    radioButton9.Checked = false;
                    radioButton10.Checked = false;
                    radioButton11.Checked = false;
                    radioButton12.Checked = false;
                    richTextBox1.Clear();
                    richTextBox1.Enabled = false;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;

            if(comboBox1.Text == "KORANGI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("KORANGI 1");
                comboBox2.Items.Add("KORANGI 2");
                comboBox2.Items.Add("KORANGI 3");
                comboBox2.Items.Add("KORANGI 4");
                comboBox2.Items.Add("KORANGI 5");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("BLOCK 1");
                comboBox2.Items.Add("BLOCK 2");
                comboBox2.Items.Add("BLOCK 3");
                comboBox2.Items.Add("BLOCK 4");
                comboBox2.Items.Add("BLOCK 5");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
