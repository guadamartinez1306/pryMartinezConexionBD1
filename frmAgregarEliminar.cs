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
using System.Data.SqlClient;

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
            if(txtNombreAgregar.Text == "") 
            {
                MessageBox.Show("Complete el " + lblNombreAgregar.Text);
                txtNombreAgregar.Focus();
                txtNombreAgregar.BackColor = Color.Red;
            }
            else 
            { 
                if(txtDescripcion.Text == "") 
                {
                    MessageBox.Show("Complete la " + lblDescripcion.Text);
                    txtDescripcion.Focus();
                    txtDescripcion.BackColor = Color.Red;
                }
                else 
                { 
                    if(txtPrecio.Text == "") 
                    {
                        MessageBox.Show("Complete el " + lblPrecio.Text);
                        txtPrecio.Focus();
                        txtPrecio.BackColor = Color.Red;
                    }
                    else 
                    { 
                        if(txtStock.Text == "") 
                        {
                            MessageBox.Show("Complete el " + lblStock.Text);
                            txtStock.Focus();
                            txtStock.BackColor = Color.Red;
                        }
                        else 
                        { 
                            if(cmbCategoria.SelectedIndex == -1) 
                            {
                                MessageBox.Show("Complete la " + lblCategoria.Text);
                                cmbCategoria.Focus();
                                cmbCategoria.BackColor = Color.Red;
                            }
                            else 
                            {
                                Productos.Agregar(txtNombreAgregar.Text, txtDescripcion.Text, txtPrecio.Text, txtStock.Text, cmbCategoria.SelectedValue.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void frmAgregarEliminar_Load(object sender, EventArgs e)
        {
            Productos.CargarCombo(cmbCategoria);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtNombreEliminar.Text == "") 
            {
                MessageBox.Show("Complete el " + lblNombreEliminar.Text);
                txtNombreEliminar.Focus();
                txtNombreEliminar.BackColor = Color.Red;
            }
            else 
            {
                Productos.Eliminar(txtNombreEliminar.Text);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmComercio f = new frmComercio();
            f.Show();
            this.Close();
        }

        private void txtNombreAgregar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            
        }

        private void txtDescripcion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
