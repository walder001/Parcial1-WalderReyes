using Parcial1_WalderReyes.DAL;
using Parcial1_WalderReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_WalderReyes.BLL
{
    public class UbicacionBLL
    {

        public static Ubicacion Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ubicacion ubicacion = new Ubicacion();
            try
            {
                ubicacion = contexto.Ubicacion.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return ubicacion;
        }


        public static bool Guardar(Ubicacion ubicacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ubicacion.Add(ubicacion) != null)
                    paso = contexto.SaveChanges() > 0;
               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Ubicacion ubicacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var buscar = contexto.Productos.Find(ubicacion.Id);
                contexto.Entry(ubicacion).State = System.Data.Entity.EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Ubicacion.Find(id);
              contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static List<Ubicacion> GetList(Expression<Func<Ubicacion, bool>> ubicacion)
        {
            Contexto contexto = new Contexto();
            List<Ubicacion> lista = new List<Ubicacion>();
            try
            {
                lista = contexto.Ubicacion.Where(ubicacion).ToList();

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
