using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaFinal.Models;

namespace VeterinariaFinal.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            List<producto> listado;
            using (var db = new VETERINARIAEntities())
            {
                listado = db.producto.ToList();
            }
            return View(listado);
        }
    }
}