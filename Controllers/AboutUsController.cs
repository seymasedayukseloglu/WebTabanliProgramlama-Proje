using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace Florals.Controllers
{
    public class AboutUsController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}
