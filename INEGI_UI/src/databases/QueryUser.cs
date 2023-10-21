using MySql.Data.MySqlClient;
using INEGI.src.models;

namespace INEGI.src.databases
{
    public class QueryUser: Conexion
    {
        // public bool Login(ModelUser mdUser)
        // {
        //     using (MySqlConnection conn = GetConnection())
        //     {
        //         string query = "SELECT * FROM usuario WHERE nickname = @nickname AND contrasena = @contrasena";
        //         try
        //         {
        //             conn.Open();
        //             using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //             {
        //                 cmd.Parameters.AddWithValue("@nickname", mdUser.nickname);
        //                 cmd.Parameters.AddWithValue("@contrasena", mdUser.password);
        //                 cmd.Prepare();
        //                 using (MySqlDataReader reader = cmd.ExecuteReader())
        //                 {
        //                     if (reader.HasRows)
        //                     {
        //                         return true;
        //                     }
        //                     else
        //                     {
        //                         return false;
        //                     }
        //                 }                        
        //             }
        //         }
        //         catch (Exception)
        //         {
        //             MessageBox.Show("Error al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //             return false;
        //         }
        //     }
        // }
        
        public bool Login(ModelUser mdUser)
        {
            using MySqlConnection conn = GetConnection();
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