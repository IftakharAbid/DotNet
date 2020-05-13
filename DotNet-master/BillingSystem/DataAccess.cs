using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace BillingSystem
{
    class DataAccess
    {
        public static DataTable GetDataTable(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True"); con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public static void excuteQuery(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1TD0271\\SQLEXPRESS;Initial Catalog=Billing_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
