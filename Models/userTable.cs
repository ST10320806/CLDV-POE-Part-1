using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace POE1.Models
{
    public class userTable
    {
        public static string con_string = "Server=tcp:jesse-weeder-sql-server.database.windows.net,1433;Initial Catalog=jesse-weeder-db;Persist Security Info=False;User ID=Jesse;Password=082Minute;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(con_string);
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public int insert_User(userTable m)
        {

            try
            {
                string sql = "INSERT INTO userTable (userName, userSurname, userEmail) VALUES (@Name,@Surname,@Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Email", m.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
