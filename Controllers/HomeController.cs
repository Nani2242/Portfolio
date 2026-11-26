using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers;
public class HomeController : Controller {
 public IActionResult Index() => View();
 public IActionResult About() => View();
 public IActionResult Error() => View();
}