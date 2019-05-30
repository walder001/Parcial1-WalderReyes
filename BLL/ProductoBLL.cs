using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_WalderReyes.Entidades;
using Parcial1_WalderReyes.DAL;

namespace Parcial1_WalderReyes.BLL
{
    public class ProductoBLL
    {
       
        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos productos = new Productos();
            try
            {
                productos = contexto.Productos.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return productos;
        }

        public static bool buscar(Productos productos)
        {
            Contexto contexto = new Contexto();

            try
            {
                var buscar = contexto.Productos.Find(productos.ProductoId);
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }
            return buscar;
        }
        public static bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Productos.Add(productos) != null)
                    paso = contexto.SaveChanges() > 0;

            }
            catch(Exception)
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
