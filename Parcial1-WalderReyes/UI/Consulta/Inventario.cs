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
    public partial class Inventario : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source =.\SQLEXPRESS; user = sa; password =  Initial Catalog = Parcial1-WalderReyesDb; Integrated Security = True");
        string query = @"Select Sum(ValorInventario) from [DbParcial1-WalderReyes].[dbo].[Productos];";
       

        public void Mostrar()
        {
            cn.Close();
            cn.Open();
            string query = @"Select Sum(ValorInventario) from [DbParcial1-WalderReyes].[dbo].[Productos];";
            SqlCommand cm = new SqlCommand(query, cn);
            float mostrar = Convert.ToSingle(cm.ExecuteScalar());
            InventariotextBox1.Text = mostrar.ToString();

        }


        public Inventario()
        {

            InitializeComponent();
            Mostrar();

        }


        

       
        private void Button1_Click(object sender, EventArgs e)
        {

            Mostrar();

        }

      

        
    }
}
