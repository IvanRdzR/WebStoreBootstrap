using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebStoreBootstrap.Models;

namespace WebStoreBootstrap.Controllers
{
    public class HomeController : Controller
    {
        //public JsonResult Index()
        //{
        //    return Json(new { Id = 1,Name = "Ivan" });
        //}
        private IWorker iWorker;

        ////[ApiController]
        ////[Route("[controller]/[action]")]
        ////[Route("")]
        ////[Route("Home")]
        ////[Route("Home/Index")]
        public HomeController(IWorker IWorker)
        {
            iWorker = IWorker;
        }
        public string Index()
        {
            return iWorker.GetDataWorker(1).Name;
        }
        //public JsonResult Details()
        //{
        //    Worker model = iWorker.GetDataWorker(4);
        //    return Json(model);
        //}

        //public ViewResult Index()
        //{

        //    Worker model = iWorker.GetDataWorker(1);
        //    return View(model);
        //}
        public ViewResult Details()
        {
            Worker model = iWorker.GetDataWorker(2);

            //ViewData["Lista Worker"] = "LISTA WORKER";
            //ViewData["Worker"] = model;

            return View(model);
        }

        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //public ViewResult Index (int id)
        //{
        //    var modelo = Worker.IWorker.DameTodosLosWorker();
        //    return View(modelo);
        //}
        //[Route("Home/Details/{id?}")]
        //public ViewResult Details(int? id)
        //{

        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
