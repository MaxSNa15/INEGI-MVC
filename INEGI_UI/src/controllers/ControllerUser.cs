using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerUser
    {
        private QueryUser qyUser;
        private ModelUser mdUser;
        private FrmLogin vwLogin;

        public ControllerUser(QueryUser qyUser ,ModelUser mdUser, FrmLogin vwLogin)
        {
            this.qyUser = qyUser;
            this.mdUser = mdUser;
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
            mdUser.nickname = vwLogin.txtNick.Text;
            mdUser.password = vwLogin.txtPass.Text;
            
            if (qyUser.Login(mdUser))
            {
                MessageBox.Show("Bienvenido", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vwLogin.Hide();
                ControllerPricipal controllerPricipal = new ControllerPricipal(new FrmPrincipal());
                controllerPricipal.RunForm();
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