using System.Linq;
using System.Web.Mvc;
using MVCOnlineTicaret.Models.Classes;
namespace MVCOnlineTicaret.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private  Context C { get; } = new Context();

        public ActionResult Index()
        {
            var adderley = C.Categories.ToList();
            return View(adderley);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            C.Categories.Add(category);
            C.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            var category = C.Categories.Find(id);
            if (category != null)
            {
                C.Categories.Remove(category);
                C.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult GetCategory(int id)
        {
            var category = C.Categories.Find(id);
            return View("GetCategory",category);
        }

        public ActionResult Update(Category c)
        {
            var category = C.Categories.Find(c.CategoryId);
            if (category != null) category.CategoryName = c.CategoryName;
            C.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}