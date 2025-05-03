using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryMartinezConexionBD1
{
    internal class clsConexionBD
    {

        #region Conexion
        private static string ConexionBD = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        public static SqlConnection ConectarBase()
        {
            SqlConnection conexion = new SqlConnection(ConexionBD);
            try
            {
                conexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }

            return conexion;
        }

        #endregion
    }
}
