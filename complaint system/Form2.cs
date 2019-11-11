using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace complaint_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        
            cns();
            fillChart();
        }


        DataTable dt;
        DataTable dts;
        DataTable dtsu;
        DataTable dtw;
        DataTable dtin;
        public void loadp()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from POLICE", con.connect());
            dt = new DataTable();
            adp.Fill(dt);

        }

        public void loadsu()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from SUIGAS", con.connect());
            dtsu = new DataTable();
            adp.Fill(dtsu);

        }

        public void loads()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from kelectric", con.connect());
            dts = new DataTable();
            adp.Fill(dts);

        }

        public void loadw()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from WATER", con.connect());
            dtw = new DataTable();
            adp.Fill(dtw);

        }

        public void loadin()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from INCOMETAX", con.connect());
            dtin = new DataTable();
            adp.Fill(dtin);

        }

        // SqlConnection con;
        connection con = new connection();
        graph1class g1 = new graph1class();
        private void cns()
        {
           // con = new SqlConnection("Data Source=DESKTOP-K4OP1A5;Initial Catalog=complaint_system;Integrated Security=True");
            //con.Open();
            con.connect();
            loads();
            loadp();
            loadsu();
            loadw();
            loadin();
        }

        private void fillChart()
        {

            chart1.Series["Police"].Points.AddY(dt.Rows[0]["cn"].ToString());
            chart1.Series["suigas"].Points.AddY(dtsu.Rows[0]["cn"].ToString());
            chart1.Series["Kesc"].Points.AddY(dts.Rows[0]["cn"].ToString());
            chart1.Series["water"].Points.AddY(dtw.Rows[0]["cn"].ToString());
            chart1.Series["incometax"].Points.AddY(dtin.Rows[0]["cn"].ToString());


            chart1.Titles.Add("Complaint Chart");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }  


    }
}
