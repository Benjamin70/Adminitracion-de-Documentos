using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class Departamento_Negocio
    {
        private static Departamento_Datos ejecutor = new Departamento_Datos();
        public static List<Departamentos> ListadoDepartamentos()
        {
            return ejecutor.ListadoDepartamentos();
        }
        public static void Agregar(Departamentos Dpto)
        {
            ejecutor.Agregar(Dpto);
        }
        public static Departamentos GetDepartmento(int Id)
        {
            return ejecutor.GetDepartmento(Id);
        }
        public static void Editar(Departamentos Dpto)
        {
            ejecutor.Editar(Dpto);
        }
        public static void Eliminar(int Id)
        {
            ejecutor.Eliminar(Id);
        }
    }
}
