using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;
using Microsoft.Data.SqlClient;

namespace Walk_in_Style.Controllers;

public class LoginController : Controller
{
  
  SqlConnection con = new SqlConnection();
  SqlCommand cmd = new SqlCommand();
  SqlDataReader ? dr;
  


    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult services()
    {
        return View();
    }
    public IActionResult contact()
    {
        return View();
    }
    public IActionResult about()
    {
        return View();
    }
    public IActionResult login()
    {
        return View();
    }

 public IActionResult Verifylogin(LoginModel lmodel)
    {
conStr();
con.Open();
cmd.Connection = con;
cmd.CommandText="select * from Login_ps where username=@usrname and password= @pass";
cmd.Parameters.AddWithValue("@usrname",lmodel.username);
cmd.Parameters.AddWithValue("@pass",lmodel.password);

dr=cmd.ExecuteReader();

if(dr.Read()){
  string? jobrolecheck= dr["jobrole"].ToString();
  con.Close();

    if(jobrolecheck=="Seller")
    {
      return RedirectToAction("dashboard","Seller");
    }

    else if(jobrolecheck=="Admin")
    {
      return RedirectToAction("dashboard","Admin");

    }

   else{
     con.Close();
     return View("Error");
   }

}

else
{
  dr.Close();
  cmd.CommandText="select* from  Customers_ps where username=@usrname and password= @pass";
cmd.Parameters.AddWithValue("@usrname",lmodel.username);
cmd.Parameters.AddWithValue("@pass",lmodel.password);
dr=cmd.ExecuteReader();


if(dr.Read()){
  con.Close();
  return RedirectToAction("dashboard","Seller");
}
else
{
  con.Close();
  return View("Error");
}




}

    }




    [HttpGet]
    public IActionResult register()
    {
        return View();
    }

void conStr(){
    con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=cad_ps; User Id = CADBATCH01; password=CAD@123pass; TrustServerCertificate=True;";

}


  [HttpPost]
    public IActionResult registerDB(RegisterModel rmodel)
    {
      conStr();
      con.Open();
      cmd.Connection=con;
      cmd.CommandText="insert into Customers_ps(username,password,email,address, phone_number) values ('"+rmodel.username+"','"+rmodel.Password+"','"+rmodel.Email+"','"+rmodel.address+"','"+rmodel.phone_number+"')";


      int rowAffected=cmd.ExecuteNonQuery();
    
      if(rowAffected>0)
      {
        return RedirectToAction("login");

      }
      
      else
      {
        return View("error");
      }



    }












    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}