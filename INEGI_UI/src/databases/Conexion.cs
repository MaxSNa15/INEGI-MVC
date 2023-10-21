using MySql.Data.MySqlClient;

namespace INEGI.src.databases
{
    public class Conexion
    {
        private const string SERVER = "localhost";
        private const string DATABASE = "censopoblacion";
        private const string PORT = "3306";
        private const string USER = "root";
        private const string PASSWORD = "root";
        private MySqlConnection? conn;

        public MySqlConnection GetConnection()
        {
            try
            {
                string cadenaConexion = "server=" + SERVER + ";port=" + PORT + ";user id=" + USER + ";password=" + PASSWORD + ";database=" + DATABASE+";";
                conn = new MySqlConnection(cadenaConexion);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
                return conn;
        }
    }
}