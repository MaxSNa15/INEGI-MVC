using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerLogin
    {
        

        private QueryUser qyUser;
        private ModelUser mdUser;
        private FrmLogin vwLogin;

        public ControllerLogin(QueryUser qyUser ,ModelUser mdUser, FrmLogin vwLogin)
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
            FrmPrincipal vwPrincipal = new FrmPrincipal();
            if (vwLogin.txtNick.Text != "" )
            {
                if(vwLogin.txtPass.Text != "")
                {
                    mdUser.nickname = vwLogin.txtNick.Text;
                    mdUser.password = vwLogin.txtPass.Text;
                    
                    if (qyUser.Login(mdUser))
                    {
                        MessageBox.Show("Bienvenido", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vwPrincipal.FormClosed += new FormClosedEventHandler(Logout);
                        vwLogin.Hide();
                        ControllerPricipal controllerPricipal = new ControllerPricipal(qyUser, mdUser, vwPrincipal);
                        controllerPricipal.RunForm();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos.\nIntente de nuevo.");
                        vwLogin.txtPass.Clear();
                        vwLogin.txtNick.Focus();
                    }
                }
                else
                {
                    msgError("Ingrese una contraseña. ");
                }
            }
            else
            {
                msgError("Ingrese un usuario. ");
            }
        }

        private void msgError(string msg)
        {
            vwLogin.lblError.Text = "    " + msg;
            vwLogin.lblError.Visible = true;
        }

        public void Logout(object? sender, FormClosedEventArgs e)
        {
            vwLogin.txtNick.Clear();
            vwLogin.txtPass.Clear();
            vwLogin.txtNick.Focus();
            vwLogin.lblError.Visible = false;
            vwLogin.Show();
        }

        public void RunApp()
        {
            Application.Run(vwLogin);
        } 
    }
}