using System.Web.Mvc;
using WebAppDataAnalisis.BLL;

namespace WebAppDataAnalisis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Reader reader = new Reader();
            var objComplex = reader.ComputeIn();
            Writer writer = new Writer();
            writer.ComputeOut(objComplex);

            return View(objComplex);
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