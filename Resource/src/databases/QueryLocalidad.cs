using MySql.Data.MySqlClient;
using INEGI.src.models;

namespace INEGI.src.databases
{
    public class QueryLocalidad
    {
        private Conexion conexion;

        public QueryLocalidad()
        {   
            // Usar el patron singleton
            conexion = Conexion.Instance;
        }

        public bool NombreExiste(string nombre)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT COUNT(*) FROM localidades WHERE Nombre = @nombre";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Prepare();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool Insertar(ModelLocalidad mdLocalidad)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "INSERT INTO localidades (Nombre, ID_Municipio) VALUES (@nombre, @idMunicipio)";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nombre", mdLocalidad.nombre);
                cmd.Parameters.AddWithValue("@idMunicipio", mdLocalidad.idMunicipio);
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
    
        public List<string> GetNameLocalidad()
        {
            List<string> localidad = new List<string>();
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT Nombre FROM localidades";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    localidad.Add(reader.GetString("Nombre"));
                }
                return localidad;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return localidad;
            }
        }
    }
}