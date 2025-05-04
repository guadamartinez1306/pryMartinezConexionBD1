using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMartinezConexionBD1
{
    public partial class frmModificarConsultar : Form
    {
        public frmModificarConsultar()
        {
            InitializeComponent();
        }
        clsProductos Productos = new clsProductos();
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmComercio f = new frmComercio();
            f.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Productos.Consultar(dgvProductos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Productos.Modificar(Convert.ToDecimal(txtPrecio.Text), txtNombre.Text);
        }
    }
}
