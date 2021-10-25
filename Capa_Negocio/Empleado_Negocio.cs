using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{

    public class Empleado_Negocio
    {
        private static Empleado_Datos ejecutor = new Empleado_Datos();

        public static List<Empleados> ListadoEmpleados()
        {
            return ejecutor.ListadoEmpleados();
        }
        public static void Agregar(Empleados Emp)
        {
            ejecutor.Agregar(Emp);
        }
        public static Empleados GetEmpleado(int Id)
        {
            return ejecutor.GetEmpleado(Id);
        }
        public static void Editar(Empleados Emp)
        {
            ejecutor.Editar(Emp);
        }
        public static void Eliminar(int Id)
        {
            ejecutor.Eliminar(Id);
        }
    }
}
