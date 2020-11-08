using System.Web.Mvc;

namespace budzet_domowy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => RedirectToActionPermanent(nameof(BillsController.ShowExamples), "Bills");
    }
}