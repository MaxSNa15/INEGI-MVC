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
            if (vwUser.txtNick.Text == "" || vwUser.txtPass.Text == "" || vwUser.txtFirst.Text == "" || vwUser.txtLast.Text == "" || vwUser.txtNick.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Actualizar en la base de datos
                mdUser.id = int.Parse(vwUser.txtNick.Text);
                mdUser.nickname = vwUser.txtNick.Text;
                mdUser.password = vwUser.txtPass.Text;
                mdUser.firstName = vwUser.txtFirst.Text;
                mdUser.lastName = vwUser.txtLast.Text;
                // TODO: Actualizar en la base de datos
            }
        }

        private void ShearUser(object? sender, EventArgs e)
        {

        }

        private void DeleteUser(object? sender, EventArgs e)
        {

        }

        private void Close(object? sender, EventArgs e)
        {
            vwUser.Close();
        }
    }
}