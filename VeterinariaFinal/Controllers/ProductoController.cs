using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Editar(int id)
        {
            producto prod = new producto();

            using(var db = new VETERINARIAEntities())
            {
                prod = db.producto.Find(id);
            }
            return View(prod);
        }

        [HttpPost]
        public ActionResult Editar(producto prod)
        {
            var prodEdit = new producto() { idProducto = prod.idProducto, nombreProd = prod.nombreProd, precio = prod.precio };

            using (var db = new VETERINARIAEntities())
            {
                db.producto.Attach(prodEdit);
                db.Entry(prodEdit).Property(x => x.nombreProd).IsModified = true;
                db.Entry(prodEdit).Property(x => x.precio).IsModified = true;
                db.SaveChanges();

            }
            return RedirectToAction("Index", "Producto");
        }


        public ActionResult Crear()
        {
            using (var db = new VETERINARIAEntities())
            {
                List<categoria> lcategoria = new List<categoria>();
                lcategoria = db.categoria.ToList();
                ViewBag.listacategoria = lcategoria;
                return View();
            }
        }

        [HttpPost]
        public ActionResult Crear(producto prod, System.Web.UI.WebControls.FileUpload fuFoto)
        {
            System.Diagnostics.Debug.WriteLine("name:" + fuFoto.FileName);

            return RedirectToAction("Index", "Producto");
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            using(var db = new VETERINARIAEntities())
            {
                var producto = new producto { idProducto = id};
                db.Entry(producto).State = EntityState.Deleted;
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Producto");
        }

    }
}