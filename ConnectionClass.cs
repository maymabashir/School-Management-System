using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace student
{
    class ConnectionClass
    {
        public static SqlConnection connect()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q5JFJQ8\\SQLEXPRESS; Initial Catalog=School; Integrated Security=true;");
            con.Open();
            return con;
        }
    }
}
