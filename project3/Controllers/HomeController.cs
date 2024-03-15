using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project3.Models;
using Microsoft.Data.SqlClient;

namespace project3.Controllers;

public class HomeController : Controller
{

SqlConnection con = new SqlConnection();

SqlCommand com = new SqlCommand();


  SqlDataReader ? dr;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult about()
    {
        return View();
    }
    public IActionResult contact()
    {
        return View();
    }
    public IActionResult username()
    {
        return View();
    }
    public IActionResult profile()
    {
        return View();
    }
    public IActionResult logout()
    {
        return View();
    }

    public IActionResult signup()
    {
        return View();
    }

  
    public IActionResult signin()
    {
        return View();
    }

  [HttpGet]
void ConnectionString(){

con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=cad_ps; User Id = CADBATCH01; password=CAD@123pass; TrustServerCertificate=True;";

}


  [HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel)
    {
        
        ConnectionString();
        con.Open();
        com.Connection=con;
        com.CommandText="select * from signin_ps where usr_name ='"+lmodel.usr_name+"' and pass='"+lmodel.pass+"' ";


        dr=com.ExecuteReader();

if(dr.Read()){
    con.Close();
     return View("Success");

}
else
{
     con.Close();
     return View("Error");

}





       
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
