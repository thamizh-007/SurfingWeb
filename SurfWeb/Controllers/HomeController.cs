using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SurfWeb.Models;
using System.Data;
using System.Diagnostics;

namespace SurfWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //using(SqlConnection con=new SqlConnection(@"SERVER=KATHIRVELUINDIR\SQLEXPRESS;DATABASE=SALESFORCE;USER ID=SA;PASSWORD=P@ssw0rd;Encrypt=True;TrustServerCertificate=True;"))
            //{
            //    con.Open();
            //    using(SqlCommand cmd=new SqlCommand())
            //    {
            //        cmd.Connection = con;
            //        cmd.CommandText = "spInsUpdCustomer";
            //        cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //        cmd.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = 2;
            //        cmd.Parameters.Add("@NAME", SqlDbType.VarChar,50).Value = "VIJAYAN";
            //        cmd.Parameters.Add("@MOBILE", SqlDbType.Int).Value = 5324223;
            //        cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar,150).Value = "PONDICHERRY, THAVALAKUPPAM";
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
