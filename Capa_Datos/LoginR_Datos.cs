using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class LoginR_Datos
    {
        public void Acceso(Acceso Login)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                db.Acceso.Add(Login);
                db.SaveChanges();
            }

        }

        public Acceso Comprobar(string User, string Password)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                var Comprobar = db.Acceso.FirstOrDefault(u => u.Usuario == User && u.Passworld == Password);
                return Comprobar;
            }
        }
    }
}
