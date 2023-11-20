using System.Data;
using MySql.Data.MySqlClient;

namespace INEGI.src.databases
{
    public class QueryProce
    {
        private Conexion conexion;

        public QueryProce()
        {   
            // Usar el patron singleton
            conexion = Conexion.Instance;
        }

        public (List<string> vivienda, List<int> actividad) ActVivi()
        {
            List<string> vivienda = new List<string>();
            List<int> actividad = new List<int>();
            using MySqlConnection conn = conexion.GetConnection();
            using MySqlCommand cmd = new MySqlCommand("ActiVivienda", conn)
            {
                CommandType = CommandType.StoredProcedure 
            };
            try
            {
                conn.Open();
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vivienda.Add(reader.GetString(0));
                    actividad.Add(reader.GetInt32(1));
                }
                return (vivienda, actividad);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (vivienda, actividad);
            }
        }
    
        public (List<string> producto, List<int> cantidad) Promedio()
        {
            List<string> producto = new List<string>();
            List<int> cantidad = new List<int>();
            using MySqlConnection conn = conexion.GetConnection();
            using MySqlCommand cmd = new MySqlCommand("HabiVivienda", conn)
            {
                CommandType = CommandType.StoredProcedure 
            };
            try
            {
                conn.Open();
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    producto.Add(reader.GetString(0));
                    cantidad.Add(reader.GetInt32(1));
                }
                return (producto, cantidad);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (producto, cantidad);
            }
        }
    }
}