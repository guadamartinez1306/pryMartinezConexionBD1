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
using System.IO;

namespace pryMartinezConexionBD1
{
    public partial class frmComercio : Form
    {
        public frmComercio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void GrlM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEliminar f = new frmAgregarEliminar();
            f.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEliminar f = new frmAgregarEliminar();
            f.ShowDialog();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEliminar f = new frmAgregarEliminar();
            f.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarConsultar f = new frmModificarConsultar();
            f.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarConsultar f = new frmModificarConsultar();
            f.ShowDialog();
        }
    }
}
