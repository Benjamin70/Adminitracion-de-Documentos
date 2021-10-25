using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Servicios
{
    public class Secuencia_Services
    {
        public  List<Usuarios_Result> BuscarSecuencia(DateTime fecha_Incio, DateTime fecha_Fin)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                return db.Usuarios(fecha_Incio, fecha_Fin).ToList();
            }
        }
        //public void BuscarRangoFecha()
        //{

        //}
    }
}
