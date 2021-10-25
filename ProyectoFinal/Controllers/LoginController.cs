using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;
namespace ProyectoFinal.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Acceso Login)
        {
            LoginR_Negocio.Acceso(Login);
            ModelState.Clear();
            ViewBag.Registrados = "Usuario Registrado Exictosamente";
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Acceso acceso_Completo)
        {
            var Usuarios = LoginR_Negocio.Comprobar(acceso_Completo.Usuario, acceso_Completo.Passworld);
            if(Usuarios == null)
            {
                acceso_Completo.Mensaje = "Usuario y Contraseña no encontrado";
                return View("Login", acceso_Completo);
            }
            else
            {
                return RedirectToAction("Index", "Opciones");
            }
            
        }
    }
}