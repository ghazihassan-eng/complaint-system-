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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cns();
            fillChart();
        }
        connection con = new connection();

        DataTable dt;
        DataTable dts;
        DataTable dtsu;
        DataTable dtw;
        DataTable dtin;
        public void loadp()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from SOLVED_POLICE", con.connect());
            dt = new DataTable();
            adp.Fill(dt);

        }

        public void loadsu()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from SOLVED_SUIGAS", con.connect());
            dtsu = new DataTable();
            adp.Fill(dtsu);

        }

        public void loads()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from SOLVED_kelectric", con.connect());
            dts = new DataTable();
            adp.Fill(dts);

        }

        public void loadw()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from SOLVED_WATER", con.connect());
            dtw = new DataTable();
            adp.Fill(dtw);

        }

        public void loadin()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select count(name) as cn from SOLVED_INCOMTAX", con.connect());
            dtin = new DataTable();
            adp.Fill(dtin);

        }

        //SqlConnection con;
        private void cns()
        {
            //con = new SqlConnection("Data Source=DESKTOP-K4OP1A5;Initial Catalog=complaint_system;Integrated Security=True");
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
            chart1.Series["kesc"].Points.AddY(dts.Rows[0]["cn"].ToString());
            chart1.Series["water"].Points.AddY(dtw.Rows[0]["cn"].ToString());
            chart1.Series["incometax"].Points.AddY(dtin.Rows[0]["cn"].ToString());


            chart1.Titles.Add("SOLVED COMPLAINT CHART");
        }
    }
}
