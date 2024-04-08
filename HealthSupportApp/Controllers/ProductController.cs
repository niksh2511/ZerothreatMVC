using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthSupportApp.Gateway;
using HealthSupportApp.Manager;
using HealthSupportApp.Manager.DoctorManager;
using HealthSupportApp.Manager.HomeManager;
using HealthSupportApp.Manager.UserManager;
using HealthSupportApp.Models;
using HealthSupportApp.Models.HomeModel;
using HealthSupportApp.Models.MedicalModel;
using HealthSupportApp.Models.ProductModel;
using HealthSupportApp.Models.UserModel;

namespace HealthSupportApp.Controllers
{
    public class ProductController : Controller
    {
        ProductGateway productGateway = new ProductGateway();
        //List<Product> list = new List<Product>();
        
        public ActionResult Index()
        {
            ProductList products = new ProductList();
            products.Products = productGateway.GetProducts();
            return View(products);
        }

        public ActionResult AddProduct(int id) 
        {
            Product product = new Product();
            if (id > 0)
            {
                product = productGateway.GetProduct(id);
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult SaveProduct(Product product) 
        { 
            productGateway.AddProduct(product);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            productGateway.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        public ActionResult Search(string search)
        {
            ProductList products = new ProductList();
            products.Products = productGateway.Serach(search);
            //return RedirectToAction("Index", "Product");
            return View( "Index",products);
        }

        [ValidateInput(false)]
        public ActionResult GetProduct(string id)
        {
            Product product = new Product();
            ViewBag.ProductId = id;
            try
            {
                int productId = Convert.ToInt32(id);
                product = productGateway.GetProduct(productId);
                return View("ProductView",product);
            }
            catch (Exception ex)
            {
                return View("ProductView", product);
            }
        }
    }
}