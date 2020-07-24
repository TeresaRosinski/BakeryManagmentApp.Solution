using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementApp.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}