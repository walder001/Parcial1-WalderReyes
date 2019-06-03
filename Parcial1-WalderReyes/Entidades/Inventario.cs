using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_WalderReyes.Entidades
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public float Total { get; set; }

        public Inventario()
        {
            IdInventario = 0;
            Total = 0.0f;

                        
        }
        public Inventario(int id, float total)
        {
            IdInventario = id;
            Total = total;
        }
      
    }
}
