using MySql.Data.MySqlClient;

namespace INEGI.src.databases
{
    public class QueryMunicipio
    {
        private Conexion conexion;

        public QueryMunicipio()
        {   
            // Usar el patron singleton
            conexion = Conexion.Instance;
        }

        public List<string> GetNameMunicipio()
        {
            List<string> municipio = new List<string>();
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT Nombre FROM municipios";
            using MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.Prepare();
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    municipio.Add(reader.GetString("Nombre"));
                }
                return municipio;
            
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return municipio;
            }
        }
    
    }
}