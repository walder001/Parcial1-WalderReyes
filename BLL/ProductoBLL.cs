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
