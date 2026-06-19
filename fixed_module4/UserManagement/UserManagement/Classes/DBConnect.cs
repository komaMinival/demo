using System.Configuration;
using System.Data.SqlClient;

namespace UserManagement
{
    public class DBConnect
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["DemoDatabase"]
                .ConnectionString;

            return new SqlConnection(connectionString);
        }
    }
}
