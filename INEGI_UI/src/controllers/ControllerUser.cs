using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerUser
    {
        private FrmUsuario vwUser;

        public ControllerUser(FrmUsuario vwUser)
        {
            this.vwUser = vwUser;
            // Eventos
            this.vwUser.btnClose.Click += new EventHandler(Close);
        }

        private void Close(object? sender, EventArgs e)
        {
            vwUser.Close();
        }
    }
}