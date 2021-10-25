using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;
using System.Net;

namespace ProyectoFinal.Controllers
{
    public class SecuenciaController : Controller
    {
        // GET: Secuencia
        public ActionResult Index()
        {
            var Listado = Secuencia_Negocio.ListadoSecuencia();
            return View(Listado);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(GeneracionSecuencia Secuencia)
        {
            try
            {
                Secuencia_Negocio.Agregar(Secuencia);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Error al agregar depertamento");
                return View(Secuencia);
            }
        }
        public ActionResult Details(int Id)
        {
            var Detalles = Secuencia_Negocio.Detalles(Id);
            return View(Detalles);
        }

        public ActionResult Eliminar(int? Id)
        {
            if (Id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var Detalles = Secuencia_Negocio.Detalles(Id.Value);
            return View(Detalles);
        }
        [HttpPost]
        public ActionResult Eliminar(int Id)
        {
            try
            {
                Secuencia_Negocio.Eliminar(Id);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Error al eliminar una Secuencia");
                return View();
            }
          
        }
     

    }
}