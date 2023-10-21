using MySql.Data.MySqlClient;
using INEGI.src.models;

namespace INEGI.src.databases
{
    public class QueryUser
    {
        private Conexion conexion;

        public QueryUser()
        {   
            // Usar el patron singleton
            conexion = Conexion.Instance;
        }

        public bool Login(ModelUser mdUser)
        {
            using MySqlConnection conn = conexion.GetConnection();
            using MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE nickname = @nickname AND contrasena = @contrasena", conn);
        
            cmd.Parameters.AddWithValue("@nickname", mdUser.nickname);
            cmd.Parameters.AddWithValue("@contrasena", mdUser.password);
            
            try
            {
                conn.Open();
                cmd.Prepare();
                using MySqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows ? true : false; // Operador ternario
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}