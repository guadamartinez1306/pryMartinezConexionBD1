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
                    cmd.Parameters.AddWithValue("@Precio", Convert.ToInt32(Precio));
                    cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(Stock));
                    cmd.Parameters.AddWithValue("@Categoria", Convert.ToInt32(Categoria)); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Producto agregado con éxito.");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("❌ Error al agregar producto: " + ex.Message);
            }
        }

        public void Eliminar(string Nombre) 
        {
            using (SqlConnection connection = clsConexionBD.ConectarBase())
            try 
            {
                    string deleteQuery = "DELETE FROM Productos WHERE Nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("❌ Producto eliminado.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar producto: " + ex.Message);
            }
        }

        public void Consultar(DataGridView dgvProductos) 
        {
            using (SqlConnection connection = clsConexionBD.ConectarBase())
            try 
            {
                    string selectQuery = "SELECT P.Nombre, P.Precio, P.Stock, C.Nombre AS Categoria FROM Productos P JOIN Categorias C ON P.CategoriaId = C.Id";
                    SqlCommand cmd = new SqlCommand(selectQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    
                    adapter.Fill(tabla);
                    dgvProductos.DataSource = tabla;

            }
            catch (Exception ex) 
            {
               MessageBox.Show("❌ Error al consultar productos: " + ex.Message);
            }
        }

        public void Modificar(string Precio, string Nombre) 
        {
            using (SqlConnection connection = clsConexionBD.ConectarBase())
                try 
                {
                    string updateQuery = "UPDATE Productos SET Precio = @precio WHERE Nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToInt32(Precio));
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("🔄 Producto actualizado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al modificar producto: " + ex.Message);
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
