using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocio;
using Capa_Entidad;
using System.Net;

namespace ProyectoFinal.Controllers
{
    public class DepartamentosController : Controller
    {
        // GET: Departamentos
        public ActionResult Index()
        {
            var Dpto = Departamento_Negocio.ListadoDepartamentos();
            return View(Dpto);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Departamentos Dpto)
        {
            try
            {
                Departamento_Negocio.Agregar(Dpto);
                return RedirectToAction("Index");
            }
            catch (Exception er)
            {
                ModelState.AddModelError("", "Error al agregar depertamento");
                return View(Dpto);
            }
           
        }

        public ActionResult GetDepartamento(int Id)
        {
            var Dpto = Departamento_Negocio.GetDepartmento(Id);
            return View(Dpto);
        }
        public ActionResult Editar(int Id)
        {
            var Dpto = Departamento_Negocio.GetDepartmento(Id);
            return View(Dpto);
        }
        [HttpPost]
        public ActionResult Editar(Departamentos Dpto)
        {
            try
            {
                Departamento_Negocio.Editar(Dpto);
                return RedirectToAction("Index");
            }
            catch (Exception er)
            {
                ModelState.AddModelError("", "Error al agregar depertamento");
                return View(Dpto);
            }
        }
        public ActionResult Eliminar(int? Id)
        {
            if (Id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var Dpto = Departamento_Negocio.GetDepartmento(Id.Value);
            return View(Dpto);
        }
        [HttpPost]
        public ActionResult Eliminar(int Id)
        {
            try
            {
                Departamento_Negocio.Eliminar(Id);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Error al eliminar un depertamento");
                return View();
            }
        }
    }
}