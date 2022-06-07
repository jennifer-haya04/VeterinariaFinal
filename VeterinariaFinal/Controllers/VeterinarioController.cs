using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaFinal.Models;

namespace VeterinariaFinal.Controllers
{
    public class VeterinarioController : Controller
    {
        // GET: Veterinario
        public ActionResult Index()
        {
            List<veterinario> listado;
            using(var db = new VETERINARIAEntities())
            {
                listado = db.veterinario.ToList();
            }
            return View(listado);
        }
    }
}