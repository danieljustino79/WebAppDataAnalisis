using System.Web.Mvc;
using WebAppDataAnalisis.BLL;

namespace WebAppDataAnalisis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag["def"] = System.Environment. System.Environment.GetEnvironmentVariable("%homepath%");
            Reader reader = new Reader();            
            return View(reader.ComputeIn());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}