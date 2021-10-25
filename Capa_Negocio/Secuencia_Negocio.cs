using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public  class Secuencia_Negocio
    {
        private static Secuencia_Datos ejecutor = new Secuencia_Datos();

        public static List<GeneracionSecuencia> ListadoSecuencia()
        {
            return ejecutor.ListadoSecuencia();
        }
        public static void Agregar(GeneracionSecuencia Secuencia)
        {
            ejecutor.Agregar(Secuencia);
        }
        public static GeneracionSecuencia Detalles(int Id)
        {
            return ejecutor.Detalles(Id);
        }
        public  static void Eliminar(int Id)
        {
            ejecutor.Eliminar(Id);
        }
    }
}
