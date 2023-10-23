using MySql.Data.MySqlClient;
using INEGI.src.models;

namespace INEGI.src.databases
{
    public class QueryActividad
    {
        private Conexion conexion;

        public QueryActividad()
        {   
            // Usar el patron singleton
            conexion = Conexion.Instance;
        }

        public bool Ingresar(ModelActividad mdActivida)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "INSERT INTO ActividadEconomica (Descripcion) VALUES (@descripcion)";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@descripcion", mdActivida.descripcion);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    
        public List<string> GetNameActividad()
        {
            List<string> actividad = new List<string>();
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT Descripcion FROM ActividadEconomica";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    actividad.Add(reader.GetString("Descripcion"));
                }
                return actividad;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return actividad;
            }
        }
    }
}