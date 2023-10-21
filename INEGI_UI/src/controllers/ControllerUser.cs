using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerUser
    {
        private ModelUsuer mdUsuer;
        private FrmLogin vwLogin;

        public ControllerUser(ModelUsuer mdUsuer, FrmLogin vwLogin)
        {
            this.mdUsuer = mdUsuer;
            this.vwLogin = vwLogin;
            //Eventos
            this.vwLogin.lnlSalir.Click += new EventHandler(Salir);
            this.vwLogin.btnLogin.Click += new EventHandler(Ingresar);
        }

        private void Salir(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Ingresar(object? sender, EventArgs e)
        {
            mdUsuer.nickname = vwLogin.txtNick.Text;
            mdUsuer.password = vwLogin.txtPass.Text;
            QueryUser queryUser = new QueryUser();
            if (queryUser.Login(mdUsuer))
            {
                MessageBox.Show("Bienvenido", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RunApp()
        {
            Application.Run(vwLogin);
        } 
    }
}