using MySql.Data.MySqlClient;

namespace INEGI.src.databases
{
    public class Conexion
    {
        private readonly string SERVER = "localhost";
        private readonly string DATABASE = "censopoblacion";
        private readonly string PORT = "3306";
        private readonly string USER = "root";
        private readonly string PASSWORD = "root";
        private MySqlConnection? conn;

        // 1-Private static instance
        private static Conexion? _instance;

        // 2-Public static property to access the instance
        public static Conexion Instance => _instance ??= new Conexion();

        // 3-Private constructor
        private Conexion() {}

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