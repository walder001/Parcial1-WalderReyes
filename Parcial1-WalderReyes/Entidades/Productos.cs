using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_WalderReyes.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Costo { get; set; }
        public float ValorInventario { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0.0f;
            ValorInventario = 0.0f;
        }
        public Productos(int productoId, string descripcion, int existencia, float costo, float valorInventario)
        {
            ProductoId = productoId;
            Descripcion = descripcion;
            Existencia = existencia;
            Costo = costo;
            ValorInventario = valorInventario;
        }
    }
   


}
