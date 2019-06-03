using Parcial1_WalderReyes.BLL;
using Parcial1_WalderReyes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_WalderReyes.UI.Consulta
{
    public partial class cInventario : Form
    {
        

        public cInventario()
        {

            InitializeComponent();
            Mostrar();

        }


        public void Mostrar()
        {
            Inventario inventario = InventarioBLL.Buscar(1);
            double total;
            total = inventario.Total;
            InventariotextBox1.Text = total.ToString();
        }

       
        private void Button1_Click(object sender, EventArgs e)
        {

            Mostrar();

        }

    }
}
