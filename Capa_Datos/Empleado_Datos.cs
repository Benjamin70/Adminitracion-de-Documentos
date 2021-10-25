using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data.Entity;

namespace Capa_Datos
{
    public class Empleado_Datos
    {
        public List<Empleados> ListadoEmpleados()
        {
            using (var db = new ProyectoFinalPEntities())
            {
                return db.Empleados.ToList();
            }
        }

        public void Agregar(Empleados Emp)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                db.Empleados.Add(Emp);
                db.SaveChanges();
            }
        }

        public Empleados GetEmpleado(int Id)
        {
            using(var db = new ProyectoFinalPEntities())
            {
                return db.Empleados.Where(x => x.Id_Emp == Id).FirstOrDefault();
            }
        }
        public void Editar(Empleados Emp)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                var D = db.Empleados.Where(x => x.Id_Emp == Emp.Id_Emp).FirstOrDefault();
                D.Nombre = Emp.Nombre;
                D.Apellido = Emp.Apellido;
                D.Correo = Emp.Correo;
                D.Apellido = Emp.Apellido;
                D.DepartamentoID = Emp.DepartamentoID;
                db.Entry(D).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public  void Eliminar(int Id)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                var Emp = db.Empleados.Where(x => x.Id_Emp == Id).FirstOrDefault();
                db.Empleados.Remove(Emp);
                db.SaveChanges();
            }
        }

    }
}
