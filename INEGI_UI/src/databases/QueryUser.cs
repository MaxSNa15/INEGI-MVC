using MySql.Data.MySqlClient;
using INEGI.src.models;
using System.Data;

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
    
        public List<string> GetFullName(string nickname)
        {
            List<string> fullName = new List<string>();
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT FIRSTNAME, LASTNAME FROM usuario WHERE Nickname = @nickname";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nickname", nickname);
            try
            {
                conn.Open();
                cmd.Prepare();
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fullName.Add(reader.GetString(0));
                    fullName.Add(reader.GetString(1));
                }
                return fullName;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return fullName;
            }
        }
    
        public DataTable? ListaUser()
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT * FROM usuario";
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
    
        public bool Insert(ModelUser mdUser)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "INSERT INTO usuario (Nickname, Contrasena, FirstName, LastName) VALUES (@nickname, @contrasena, @firstName, @lastName)";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nickname", mdUser.nickname);
                cmd.Parameters.AddWithValue("@contrasena", mdUser.password);
                cmd.Parameters.AddWithValue("@firstName", mdUser.firstName);
                cmd.Parameters.AddWithValue("@lastName", mdUser.lastName);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    
        public bool Read(ModelUser mdUser)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "SELECT * FROM usuario WHERE ID_Usuario = @ID_Usuario";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID_Usuario", mdUser.id);
                cmd.Prepare();
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    mdUser.nickname = reader.GetString(1);
                    mdUser.password = reader.GetString(2);
                    mdUser.firstName = reader.GetString(3);
                    mdUser.lastName = reader.GetString(4);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(ModelUser mdUser)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "UPDATE usuario SET Nickname = @nickname, Contrasena = @contrasena, FirstName = @firstName, LastName = @lastName WHERE ID_Usuario = @ID_Usuario";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID_Usuario", mdUser.id);
                cmd.Parameters.AddWithValue("@nickname", mdUser.nickname);
                cmd.Parameters.AddWithValue("@contrasena", mdUser.password);
                cmd.Parameters.AddWithValue("@firstName", mdUser.firstName);
                cmd.Parameters.AddWithValue("@lastName", mdUser.lastName);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(ModelUser mdUser)
        {
            using MySqlConnection conn = conexion.GetConnection();
            string query = "DELETE FROM usuario WHERE ID_Usuario = @ID_Usuario";
            using MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID_Usuario", mdUser.id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}