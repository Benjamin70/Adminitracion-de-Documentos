using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;
using Capa_Servicios;

namespace ProyectoFinal.Controllers
{
    public class ReporteSecuenciaController : Controller
    {
        Secuencia_Services ejecutor = new Secuencia_Services();
        // GET: ReporteSecuencia
        public ActionResult Index()
        {
            var Listado = Secuencia_Negocio.ListadoSecuencia();
            return View(Listado);
        }
        [HttpPost]
        public ActionResult Buscar(DateTime fecha_Incio, DateTime fecha_Fin)
        {
            return View(ejecutor.BuscarSecuencia(fecha_Incio, fecha_Fin));
        }

    }
}