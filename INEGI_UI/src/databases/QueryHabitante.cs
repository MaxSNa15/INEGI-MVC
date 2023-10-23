using MySql.Data.MySqlClient;
using INEGI.src.models;
using System.Data;

namespace INEGI.src.databases
{
    public class QueryHabitante
    {
        private Conexion conexion;

        public QueryHabitante()
        {   
            // Usar el patron singleton
            conexion = Conexion.Instance;
        }

        public bool Insertar(ModelHabitante mdHabitante)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "INSERT INTO Habitante (Nombre, FechaNacimiento, Genero, ID_Vivienda) VALUES (@nombre, @fechaNacimiento, @genero, @idVivienda)";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nombre", mdHabitante.nombre);
                cmd.Parameters.AddWithValue("@fechaNacimiento", mdHabitante.fechaNacimiento);
                cmd.Parameters.AddWithValue("@genero", mdHabitante.genero);
                cmd.Parameters.AddWithValue("@idVivienda", mdHabitante.idVivienda);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    
        public DataTable? ListaHabitante()
        {
            using MySqlConnection conn = conexion.GetConnection();  
            string query = "SELECT h.ID_Habitante, h.Nombre, h.FechaNacimiento, h.Genero, v.Direccion, v.Tipo, l.Nombre AS NombreLocalidad, m.Nombre AS NombreMunicipio FROM Habitante h JOIN Vivienda v ON h.ID_Vivienda = v.ID_Vivienda JOIN Localidades l ON v.ID_Localidad = l.ID_Localidad JOIN Municipios m ON l.ID_Municipio = m.ID_Municipio";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                using MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}