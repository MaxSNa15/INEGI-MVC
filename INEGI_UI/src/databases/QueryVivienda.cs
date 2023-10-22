using MySql.Data.MySqlClient;
using INEGI.src.models;

namespace INEGI.src.databases
{
    public class QueryVivienda
    {
        private Conexion conexion;

        public QueryVivienda()
        {   
            // Usar el patron singleton
            conexion = Conexion.Instance;
        }

        public bool Insertar(ModelVivienda mdVivienda)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "INSERT INTO Vivienda (Direccion, Tipo, ID_Localidad) VALUES (@direccion, @tipo, @idLocalidad)";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@direccion", mdVivienda.direccion);
                cmd.Parameters.AddWithValue("@tipo", mdVivienda.tipovi);
                cmd.Parameters.AddWithValue("@idLocalidad", mdVivienda.idLocalidad);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    
    }
}