using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Datos
{
    public class Secuencia_Datos
    {
        string SiglasOrigen;
        string SiglasDetino;
        int Codigo = 0;
        string Formula;
        string SecuenciaDocumento;
        public List<GeneracionSecuencia> ListadoSecuencia()
        {
            using (var db = new ProyectoFinalPEntities())
            {
               return db.GeneracionSecuencia.ToList();
            }
        }

        public void Agregar(GeneracionSecuencia Secuencia)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                SiglasOrigen = Secuencia.SiglasDpto;
                SiglasDetino = Secuencia.Destino;
                Secuencia.Secuencia = GenerarSecuencia();
                db.GeneracionSecuencia.Add(Secuencia);
                db.SaveChanges();
            }
        }

        public GeneracionSecuencia Detalles(int Id)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                return db.GeneracionSecuencia.Where(x => x.Id_Secuencia == Id).FirstOrDefault();
            }
        }
        public void Eliminar(int Id)
        {
            using (var db = new ProyectoFinalPEntities())
            {
                var Secuencia = db.GeneracionSecuencia.Where(x => x.Id_Secuencia == Id).FirstOrDefault();
                db.GeneracionSecuencia.Remove(Secuencia);
                db.SaveChanges();
            }
        }
        public string GenerarSecuencia()
        {
            Codigo += 1;
            Formula = Codigo.ToString().PadLeft(4,'0');
            SecuenciaDocumento = ($"2021-{SiglasOrigen.Substring(0,4)}-{SiglasDetino.Substring(0,4)}-{Formula}");
            return SecuenciaDocumento;
        }
    }
}
