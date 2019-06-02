using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_WalderReyes.UI.Registro
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Decimal n, n1, r;
            n = numericUpDown1.Value;
            n1 = numericUpDown2.Value;
            r = (n*n1);
             numericUpDown3.Value = r;
           



        }

        private void MaskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
       
        }
    }
}
