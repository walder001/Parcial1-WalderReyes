using Parcial1_WalderReyes.BLL;
using Parcial1_WalderReyes.Entidades;
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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            ProductoIdnumericUpDown1.Value = 0;
            DescripciontextBox1.Text = string.Empty;
            CostotextBox2.Text = string.Empty;
            ExistenciatextBox3.Text = string.Empty;
            InventariotextBox4.Text = string.Empty;

        }

        public Productos LlenarClase()
        {
            Productos pro = new Productos();
            pro.ProductoId = Convert.ToInt32(ProductoIdnumericUpDown1.Value);
            pro.Descripcion = DescripciontextBox1.Text;
            pro.Costo = Convert.ToSingle(CostotextBox2.Text);
            pro.Existencia = Convert.ToInt32(ExistenciatextBox3.Text);
            pro.ValorInventario = Convert.ToSingle(InventariotextBox4.Text);
            return pro;

        }

        private void LLenarCampo(Productos pro)
        {
            ProductoIdnumericUpDown1.Value = pro.ProductoId;
            DescripciontextBox1.Text = pro.Descripcion;
           CostotextBox2.Text = Convert.ToString(pro.Costo);
            ExistenciatextBox3.Text = Convert.ToString(pro.Existencia);
            InventariotextBox4.Text = Convert.ToString(pro.ValorInventario);

        }


        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();
            if (ProductoIdnumericUpDown1.Value == 0)
            {
                ErrorProvider.SetError(ProductoIdnumericUpDown1,"El campo es invalido");
                ProductoIdnumericUpDown1.Focus();
                paso = false;
            }
            if (DescripciontextBox1.Text == string.Empty)
            {
                ErrorProvider.SetError(DescripciontextBox1, "El campo esta vacio");
                DescripciontextBox1.Focus();
                paso = false;


            }
            if (string.IsNullOrWhiteSpace(CostotextBox2.Text))
            {
                ErrorProvider.SetError(CostotextBox2, "El Campo invalido");
                CostotextBox2.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ExistenciatextBox3.Text))
            {
                ErrorProvider.SetError(ExistenciatextBox3, "El campo es invalido");

            }
            return paso;
       
        }
        private bool BaseDato(int id)
        {
            Productos pro = ProductoBLL.Buscar((int)ProductoIdnumericUpDown1.Value);
            return (pro != null);
        }


        
        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        

        private void Guardar_Click(object sender, EventArgs e)
        {
            Productos pro;
            bool paso = false;

            if (!Validar())
                return;

            pro = LlenarClase();
            limpiar();

            //Determinar si es guardar o modificar
            if (ProductoIdnumericUpDown1.Value == 0)
                paso = ProductoBLL.Guardar(pro);
            else
            {
                
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            ProductoBLL.Eliminar((int)ProductoIdnumericUpDown1.Value);
        }

        public void Metodo()
        {
            if (CostotextBox2.Text.Length > 0 && ExistenciatextBox3.Text.Length > 0)
                InventariotextBox4.Text = Convert.ToString(Convert.ToInt32(CostotextBox2.Text) * Convert.ToInt32(ExistenciatextBox3.Text));

            if (CostotextBox2.Text.Length > 0 && ExistenciatextBox3.Text.Length == 0)
                InventariotextBox4.Text = "0";

            if (CostotextBox2.Text.Length == 0 && ExistenciatextBox3.Text.Length > 0)
                InventariotextBox4.Text = "0";

            if (CostotextBox2.Text.Length == 0 && ExistenciatextBox3.Text.Length == 0)
                InventariotextBox4.Text = "0";
        }

        private void InventariotextBox4_TextChanged(object sender, EventArgs e)
        {
            Metodo();
           
        }

        private void ExistenciatextBox3_TextChanged(object sender, EventArgs e)
        {
            Metodo();
        }
    }
}

    

