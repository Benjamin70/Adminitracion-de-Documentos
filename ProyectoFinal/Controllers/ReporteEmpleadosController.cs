using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocio;
using Capa_Entidad;

namespace ProyectoFinal.Controllers
{
    public class ReporteEmpleadosController : Controller
    {
        // GET: ReporteEmpleados
        public ActionResult Index()
        {
            var Listado = Empleado_Negocio.ListadoEmpleados();
            return View(Listado);
        }
    }
}