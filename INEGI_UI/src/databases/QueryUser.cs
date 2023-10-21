using MySql.Data.MySqlClient;
using INEGI.src.models;

namespace INEGI.src.databases
{
    public class QueryUser: Conexion
    {
        public bool Login(ModelUsuer mdUser)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM usuario WHERE nickname = @nickname AND contrasena = @contrasena";
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nickname", mdUser.nickname);
                        cmd.Parameters.AddWithValue("@contrasena", mdUser.password);
                        
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}