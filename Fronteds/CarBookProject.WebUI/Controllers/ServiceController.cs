using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public  IActionResult Index()
        {
            return View();
        }
    }
}
