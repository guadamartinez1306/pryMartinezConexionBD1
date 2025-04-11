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

namespace pryMartinezConexionBD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=PC240;Database=Comercio;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Productos";
                    SqlCommand command = new SqlCommand(query, connection);
                    string resultado = "";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultado += reader["Nombre"].ToString() + "\n";
                        }
                    }

                    MessageBox.Show(resultado, "🛒 Productos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al conectar: " + ex.Message);
                }
            }
        }
    }
}
