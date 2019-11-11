using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace complaint_system
{
    class connection
    {
        SqlConnection con = null;

        public SqlConnection connect()
        {
            
        con = new SqlConnection("Data Source=DESKTOP-K4OP1A5;Initial Catalog=complaint_system;Integrated Security=True");
        con.Open();
        return con;
        }
    }
}
