using Microsoft.AspNetCore.Mvc;

namespace ElectronNET_API_Demos_Zh_CN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}