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
            f.ShowDialog();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Productos.Consultar(dgvProductos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           if(txtNombre.Text == "") 
           {
                MessageBox.Show("Complete el " + lblNombre.Text);
                txtNombre.Focus();
                txtNombre.BackColor = Color.Red;
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
                    if(txtDescripcionNom.Text == "") 
                    {
                        MessageBox.Show("Complete la " + lblDescripcionNom.Text);
                        txtDescripcionNom.Focus();
                        txtDescripcionNom.BackColor = Color.Red;
                    }
                    else 
                    {
                        Productos.Modificar(txtPrecio.Text, txtNombre.Text, txtDescripcionNom.Text);
                    }
                }
           }
        }

        private void txtNombre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void txtPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btnModificarCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Complete el " + lblCodigo.Text);
                txtCodigo.Focus();
                txtCodigo.BackColor = Color.Red;
            }
            else
            {
                if (txtPrecioCod.Text == "")
                {
                    MessageBox.Show("Complete el " + lblPrecioCod.Text);
                    txtPrecioCod.Focus();
                    txtPrecioCod.BackColor = Color.Red;
                }
                else
                {
                    if(txtDescripcionCod.Text == "") 
                    {
                        MessageBox.Show("Complete la " + lblDescripcionCod.Text);
                        txtDescripcionCod.Focus();
                        txtDescripcionCod.BackColor = Color.Red;
                    }
                    else 
                    {
                        Productos.ModificarPorCodigo(txtPrecioCod.Text, txtCodigo.Text, txtDescripcionCod.Text);
                    }
                }
            }
        }
    }
}
