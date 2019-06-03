using Parcial1_WalderReyes.DAL;
using Parcial1_WalderReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Parcial1_WalderReyes.BLL
{
    public class InventarioBLL
    {
        public static Inventario Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inventario inventario = new Inventario();
            try
            {
                inventario = contexto.Inventario.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return inventario;
        }


        public static bool Guardar(Inventario inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Inventario.Add(inventario) != null)
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

        public static bool Modificar(Inventario inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var buscar = contexto.Inventario.Find(inventario.IdInventario);
                contexto.Entry(inventario).State = System.Data.Entity.EntityState.Modified;
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
                var eliminar = contexto.Inventario.Find(id);
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
    }
}
