using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace pryMartinezConexionBD1
{
    internal class clsProductos
    {
        #region Procedimientos 
        public void Mostrar(DataGridView dgvProductos) 
        {
            using (SqlConnection connection = clsConexionBD.ConectarBase())
            try
            {
                    string query = @"SELECT p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.Stock, c.Nombre AS Categoria
                                 FROM Productos p
                                 INNER JOIN Categorias c ON p.CategoriaId = c.Id";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Utilizando un DataTable para almacenar los resultados
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);  // Llenamos el DataTable con los resultados de la consulta

                    // Asignamos el DataTable al DataGridView
                    dgvProductos.DataSource = dt; // dgvProductos es el nombre de mi grilla

            }
            catch (Exception ex)
            {
                    MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }
        }

        public void Agregar(string Nombre, string Descripcion, string Precio, string Stock,string Categoria) 
        {
            using (SqlConnection connection = clsConexionBD.ConectarBase())
            try 
            {
                    string insertQuery = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) " +
                                         "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @Categoria)";
                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(Precio));
                    cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(Stock));
                    cmd.Parameters.AddWithValue("@Categoria", Convert.ToInt32(Categoria)); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Producto agregado con éxito.");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("❌ Error al agregar: " + ex.Message);
            }
        }
        #endregion

        #region Cargar Combo
        public void CargarCombo(ComboBox combo) 
        {
            using (SqlConnection connection = clsConexionBD.ConectarBase())
            try 
            {
                    string query = "SELECT Id, Nombre FROM Categorias";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    combo.DisplayMember = "Nombre";
                    combo.ValueMember = "Id";
                    combo.DataSource = dt;
            }
            catch(Exception ex) 
            {
                    MessageBox.Show("❌ Error al cargar Categorias:" + ex.Message);
            }
        }
        #endregion
    }
}
