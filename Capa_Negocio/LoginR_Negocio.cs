using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;


namespace Capa_Negocio
{
    public class LoginR_Negocio
    {
        private static LoginR_Datos ejecutor = new LoginR_Datos();

        public static void Acceso(Acceso Login)
        {
            ejecutor.Acceso(Login);
        }
        public static Acceso Comprobar(string User, string Password)
        {
            return ejecutor.Comprobar(User, Password);
        }

    }
}
