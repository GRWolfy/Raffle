using System.Data.SqlClient;

namespace Raffle
{
    public class Connection
    {
        public static SqlConnection con;
        private static string dbconnect = "Data Source=DESKTOP-VJRTO63;Initial Catalog=Raffle;Integrated Security=True"; //connection string 

        public static void DB()
        {
            try
            {
                con = new SqlConnection(dbconnect);
                con.Open();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }
        }
    }
}
