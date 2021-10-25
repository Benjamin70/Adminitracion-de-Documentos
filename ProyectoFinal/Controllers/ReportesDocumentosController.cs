using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocio;
using Capa_Entidad;

namespace ProyectoFinal.Controllers
{
    public class ReportesDocumentosController : Controller
    {
        // GET: ReportesDocumentos
        public ActionResult Index()
        {
            var Secuencia= Secuencia_Negocio.ListadoSecuencia();
            return View(Secuencia);
        }
    }
}