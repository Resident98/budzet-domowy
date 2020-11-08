using budzet_domowy.Models;
using PagedList;
using System.Collections.Generic;
using System.Web.Mvc;

namespace budzet_domowy.Controllers
{
    public class PersonController : Controller
    {
        static public List<PersonModel> people = new List<PersonModel>();
        static private bool execute = false;
        // GET: Person
        public ActionResult ShowExamples(int? page, int? PageSize)
        {
            if (execute == false)
            {
                people = PersonModel.Examples();
                execute = true;
            }

            int pageSize = (PageSize ?? 10);
            int pageNumber = (page ?? 1);
            return View(people.ToPagedList(pageNumber, pageSize));
        }
    }
}