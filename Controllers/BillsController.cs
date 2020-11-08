using budzet_domowy.Models;
using PagedList;
using System.Collections.Generic;
using System.Web.Mvc;

namespace budzet_domowy.Controllers
{
    public class BillsController : Controller
    {
        static public List<BillModel> people = new List<BillModel>();
        static private bool execute = false;
        // GET: Bills
        public ActionResult ShowExamples(int? page, int? PageSize)
        {
            if (execute == false)
            {
                people = BillModel.Examples();
                execute = true;
            }

            int pageSize = (PageSize ?? 10);
            int pageNumber = (page ?? 1);
            return View(people.ToPagedList(pageNumber, pageSize));
        }
    }
}