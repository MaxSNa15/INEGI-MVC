using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerDash
    {
        private FrmDash vwDash;

        public ControllerDash(FrmDash vwDash)
        {
            this.vwDash = vwDash;
            // Eventos
            this.vwDash.Load += new EventHandler(Load);
            this.vwDash.btnClose.Click += new EventHandler(Close);
        }

        private void Load(object? sender, EventArgs e)
        {
            
        }
        
        private void Close(object? sender, EventArgs e)
        {
            vwDash.Close();
        }
    }
}