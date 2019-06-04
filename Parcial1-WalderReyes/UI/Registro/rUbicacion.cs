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
    public partial class rUbicacion : Form
    {
        public rUbicacion()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IdnumericUpDown1.Value = 0;
            DescripciontextBox1.Text = string.Empty;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
       
        }
        /// <returns></returns>
        public Ubicacion LlenarClase()
        {
            Ubicacion pro = new Ubicacion();
            pro.Id = Convert.ToInt32(IdnumericUpDown1.Value);
            pro.Descripcion = DescripciontextBox1.Text;
            
            return pro;

        }

        
        private void LLenarCampo(Ubicacion inv)
        {
            IdnumericUpDown1.Value = inv.Id;
            DescripciontextBox1.Text = inv.Descripcion;
          

        }

        

        /// <summary>
        /// Metodo que valida que no se ingrese valores nulos o campos vacios en otras palabras.
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();

            if (Existe())
            {
                ErrorProvider.SetError(IdnumericUpDown1, "Existe en la base de datos");
                IdnumericUpDown1.Focus();
                paso = false;

            }
            if (IdnumericUpDown1.Value == 0)
            {
                ErrorProvider.SetError(IdnumericUpDown1, "El costo no puede ser 0");
                IdnumericUpDown1.Focus();
                paso = false;

            }
            if(IdnumericUpDown1.Value > 10)
            {
                ErrorProvider.SetError(IdnumericUpDown1, "El costo no puede ser 0");
                IdnumericUpDown1.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DescripciontextBox1.Text))
            {
                ErrorProvider.SetError(DescripciontextBox1, "El campo no puede estar vacio");
                DescripciontextBox1.Focus();
                paso = false;

            }
            
            
            return paso;

        }

        private bool Existe()
        {
            Ubicacion ubi = UbicacionBLL.Buscar((int)IdnumericUpDown1.Value);
            return (ubi != null);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            Ubicacion ubicacion;
            bool paso = false;
            if (!Validar())
                return;
            ubicacion = LlenarClase();
            Limpiar();

            if (IdnumericUpDown1.Value == 0)
            {
                paso = UbicacionBLL.Guardar(ubicacion);

            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Desea modificar", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                paso = UbicacionBLL.Modificar(ubicacion);




            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            int id;
            id = (int)IdnumericUpDown1.Value;
            Limpiar();
            try
            {
                if (UbicacionBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    ErrorProvider.SetError(IdnumericUpDown1, "No se puedes eliminar una ubicacion que no existe");
                }
            }
            catch
            {
                MessageBox.Show("No puede eliminar un ubicacion que no existe");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Ubicacion ubicacion = new Ubicacion();
            int id;
            id = Convert.ToInt32(IdnumericUpDown1.Value);
            Limpiar();
            ubicacion = UbicacionBLL.Buscar(id);
            if (ubicacion != null)
            {
                MessageBox.Show("Ubicacion encontrada");
                LLenarCampo(ubicacion);
            }
            else
            {
                MessageBox.Show("Ubicacion no enctrada");
            }
        }
    }
}
