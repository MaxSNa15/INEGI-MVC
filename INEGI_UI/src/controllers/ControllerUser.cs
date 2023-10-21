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
        }

        private void Salir(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void RunApp()
        {
            Application.Run(vwLogin);
        } 
    }
}