using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerUser
    {
        private ModelUser mdUser;
        private QueryUser qyUser;
        private FrmUsuario vwUser;

        public ControllerUser(ModelUser mdUser, QueryUser qyUser, FrmUsuario vwUser)
        {
            this.mdUser = mdUser;
            this.qyUser = qyUser;
            this.vwUser = vwUser;
            // Eventos
            this.vwUser.Load += new EventHandler(Load);
            this.vwUser.btnClose.Click += new EventHandler(Close);
            this.vwUser.btnActHab.Click += new EventHandler(Up);
            this.vwUser.btnReg.Click += new EventHandler(AddUser);
            this.vwUser.btnMod.Click += new EventHandler(UpdateUser);
            this.vwUser.btnBus.Click += new EventHandler(ShearUser);
            this.vwUser.btnElim.Click += new EventHandler(DeleteUser);
        }

        public void LimpiarCampos()
        {
            vwUser.txtNick.Clear();
            vwUser.txtPass.Clear();
            vwUser.txtFirst.Clear();
            vwUser.txtLast.Clear();
        }

        private void Load(object? sender, EventArgs e)
        {
            vwUser.dgvUsuarios.DataSource = qyUser.ListaUser();
        }

        private void Up(object? sender, EventArgs e)
        {
            vwUser.dgvUsuarios.DataSource = qyUser.ListaUser();
        }

        private void AddUser(object? sender, EventArgs e)
        {
            if (vwUser.txtNick.Text == "" || vwUser.txtPass.Text == "" || vwUser.txtFirst.Text == "" || vwUser.txtLast.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Insertar en la base de datos
                mdUser.nickname = vwUser.txtNick.Text;
                mdUser.password = vwUser.txtPass.Text;
                mdUser.firstName = vwUser.txtFirst.Text;
                mdUser.lastName = vwUser.txtLast.Text;
                if (qyUser.Insert(mdUser))
                {
                    MessageBox.Show("Usuario agregado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vwUser.dgvUsuarios.DataSource = qyUser.ListaUser();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
        }

        private void UpdateUser(object? sender, EventArgs e)
        {
            if (vwUser.txtID.Text == "" || vwUser.txtNick.Text == "" || vwUser.txtPass.Text == "" || vwUser.txtFirst.Text == "" || vwUser.txtLast.Text == "" || vwUser.txtNick.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Actualizar en la base de datos
                mdUser.id = Convert.ToInt32(vwUser.txtID.Text);
                mdUser.nickname = vwUser.txtNick.Text;
                mdUser.password = vwUser.txtPass.Text;
                mdUser.firstName = vwUser.txtFirst.Text;
                mdUser.lastName = vwUser.txtLast.Text;
                if (qyUser.Update(mdUser))
                {
                    MessageBox.Show("Usuario actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vwUser.dgvUsuarios.DataSource = qyUser.ListaUser();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
        }

        private void ShearUser(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vwUser.txtID.Text))
            {
                MessageBox.Show("El campo ID no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mdUser.id = Convert.ToInt32(vwUser.txtID.Text);
        
                if (qyUser.Read(mdUser))
                {
                    vwUser.txtNick.Text = mdUser.nickname;
                    vwUser.txtPass.Text = mdUser.password;
                    vwUser.txtFirst.Text = mdUser.firstName;
                    vwUser.txtLast.Text = mdUser.lastName;
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteUser(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vwUser.txtID.Text))
            {
                MessageBox.Show("El campo ID no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mdUser.id = Convert.ToInt32(vwUser.txtID.Text);
        
                if (qyUser.Delete(mdUser))
                {
                    MessageBox.Show("Usuario eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vwUser.dgvUsuarios.DataSource = qyUser.ListaUser();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
        }

        private void Close(object? sender, EventArgs e)
        {
            vwUser.Close();
        }
    }
}