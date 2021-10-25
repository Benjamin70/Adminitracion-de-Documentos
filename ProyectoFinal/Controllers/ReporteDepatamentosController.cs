using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace ProyectoFinal.Controllers
{
    public class ReporteDepatamentosController : Controller
    {
        // GET: ReporteDepatamentos
        public ActionResult Index()
        {
            var Departamentos = Departamento_Negocio.ListadoDepartamentos();
            return View(Departamentos);
        }
    }
}