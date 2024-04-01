using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Data.SqlClient;

namespace POE1.Models
{
    public class userTable : Controller
    {
        public static string con_string ="tcp:jesse-weeder-sql-server.database.windows.net,1433;Initial Catalog = jesse - weeder - db; Persist Security Info=False;User ID = Jesse; Password=082Minute; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
    public static SqlConnection con = new SqlConnection(con_string);
    public IActionResult Index()
        {
            return View();
        }
    }
}
