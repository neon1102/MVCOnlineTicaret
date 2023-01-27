using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  MVCOnlineTicaret.Models.Classes;

namespace MVCOnlineTicaret.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        private Context C { get; } = new Context();

        public ActionResult Index()
        {
            var values = C.Departments.ToList();
            return View(values);
        }
    }
}