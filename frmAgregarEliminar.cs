using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMartinezConexionBD1
{
    public partial class frmAgregarEliminar : Form
    {
        public frmAgregarEliminar()
        {
            InitializeComponent();
        }

        clsProductos Productos = new clsProductos();
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Productos.Mostrar(dgvProductos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Productos.Agregar(txtNombreAgregar.Text, txtDescripcion.Text, txtPrecio.Text, txtStock.Text, cmbCategoria.SelectedValue.ToString());
        }

        private void frmAgregarEliminar_Load(object sender, EventArgs e)
        {
            Productos.CargarCombo(cmbCategoria);
        }
    }
}
