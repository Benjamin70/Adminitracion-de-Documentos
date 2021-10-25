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
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            var Emp = Empleado_Negocio.ListadoEmpleados();
            return View(Emp);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Empleados Emp)
        {
            try
            {
                Empleado_Negocio.Agregar(Emp);
                return RedirectToAction("Index");
            }
            catch(Exception er)
            {
                ModelState.AddModelError("Ocurrio un error al registrar un Emleado", er.Message);
                return View(Emp);
            }
        }
        public ActionResult Details(int Id)
        {
            var Emp = Empleado_Negocio.GetEmpleado(Id);
            return View(Emp);
        }
        public ActionResult Editar(int Id)
        {
            var EmpEdit = Empleado_Negocio.GetEmpleado(Id);
            return View(EmpEdit);
        }
        [HttpPost]
        public ActionResult Editar(Empleados Emp)
        {
            try
            {
                Empleado_Negocio.Editar(Emp);
                return RedirectToAction("Index");
            }
            catch(Exception et)
            {
                ModelState.AddModelError("", "Error al agregar depertamento");
                return View(Emp);
            }
        }
        public ActionResult Eliminar(int? Id)
        {
            if (Id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var Emp = Empleado_Negocio.GetEmpleado(Id.Value);
            return View(Emp);
        }
        [HttpPost]
        public ActionResult Eliminar(int Id)
        {
            try
            {
                Empleado_Negocio.Eliminar(Id);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Error al eliminar un Empleado");
                return View();
            }
        }
    }
}