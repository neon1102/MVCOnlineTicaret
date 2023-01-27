using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCOnlineTicaret.Models.Classes;
namespace MVCOnlineTicaret.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public Context C { get; } = new Context();

        public ActionResult Index()
        {
            List<Product> product;
            product = C.Products.Where(x => x.Status).ToList();
            return View(product);
        }
        public ActionResult Archive()
        {
            List<Product> product;
            product = C.Products.Where(x => x.Status == false).ToList();
            return View(product);
        }
        public ActionResult Active(int id)
        {
            var product = C.Products.Find(id);
            if (product != null)
            {
                product.Status = true;
                C.SaveChanges();
            }

            return RedirectToAction("Archive");
        }

        [HttpGet]
        public ActionResult Add()
        {
            List<SelectListItem> value1 = (from x in C.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.dgr1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            C.Products.Add(product);
            product.Status = true;
            C.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetProduct(int id)
        {
            List<SelectListItem> value1 = (from x in C.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.dgr1 = value1;

            var productvalue = C.Products.Find(id);
            return View("GetProduct", productvalue);
        }
        public ActionResult Delete(int id)
        {
            var product = C.Products.Find(id);
            if (product != null)
            {
                product.Status = false;
                C.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Update(Product product1)
        {
            var product = C.Products.Find(product1.ProductId);
            if (product != null)
            {
                product.ProductName = product1.ProductName;
                product.Brend = product1.Brend;
                product.Stock = product1.Stock;
                product.PurchasePrice = product1.PurchasePrice;
                product.SalePrice = product1.SalePrice;
                product.CategoryId = product1.CategoryId;
                product.ProductImage = product1.ProductImage;
                product.Status = true;
            }


            C.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}