using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_WalderReyes.UI.Registro;
namespace Parcial1_WalderReyes
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos pro = new rProductos();
        }
    }
}
