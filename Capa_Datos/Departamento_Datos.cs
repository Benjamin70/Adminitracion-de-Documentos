using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Datos
{
    public class Departamento_Datos
    {
        public List<Departamentos> ListadoDepartamentos()
        {
            using (var db = new ProyectoFinalPEntities())
            {
                return db.Departamentos.ToList();
            }
        }

        public void Agregar(Departamentos Dpto)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                db.Departamentos.Add(Dpto);
                db.SaveChanges();
            }
        }

        public Departamentos GetDepartmento(int Id)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                return db.Departamentos.Where(d => d.Id_Dpto == Id).FirstOrDefault();
            }
        }

        public void Editar(Departamentos Dpto)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                var D = db.Departamentos.Where(x=>x.Id_Dpto == Dpto.Id_Dpto).FirstOrDefault();
                D.Nombre = Dpto.Nombre;
                D.Siglas = Dpto.Siglas;
                db.SaveChanges();

            }
        }
        public void Eliminar(int Id)
        {
            using(var db = new ProyectoFinalPEntities())
            {
                var Dpto =  db.Departamentos.Where(d => d.Id_Dpto == Id).FirstOrDefault();
                db.Departamentos.Remove(Dpto);
                db.SaveChanges();
            }
        }
    }
}
