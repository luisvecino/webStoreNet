using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreCursoMVC.Models;

namespace WebStoreCursoMVC.Controllers
{
    public class ProductoController : Controller
    {
        private WebStoreContext context = new WebStoreContext();
        
        public ActionResult Index()
        {
            return View("Index", context.Productos.ToList());
        }
        
        public ActionResult Display(int id)
        {
            Producto producto = context.Productos.Find(id);

            //string param = Request.QueryString["id"];

            if (producto == null)
                return HttpNotFound();

            return View("Display", producto);
                        
        }
    }
}