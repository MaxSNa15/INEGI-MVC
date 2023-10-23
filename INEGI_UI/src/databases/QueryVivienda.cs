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
    
        public List<string> GetNameVivienda()
        {
            List<string> vivienda = new List<string>();
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT v.Direccion, v.Tipo, l.Nombre AS NombreLocalidad, m.Nombre AS NombreMunicipio FROM Vivienda v JOIN Localidades l ON v.ID_Localidad = l.ID_Localidad JOIN Municipios m ON l.ID_Municipio = m.ID_Municipio";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
        
            try
            {
                conn.Open();
                cmd.Prepare();
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string result = reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString();
                    vivienda.Add(result);
                }
                return vivienda;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return vivienda;
            }
        }

    }
}